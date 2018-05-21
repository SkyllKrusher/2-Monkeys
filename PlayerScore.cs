using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour {

    private Text scoreText;
    private static int score=0;

    private void Awake()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        score = 0;
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Banana")
        {
            score++;
            scoreText.text = score.ToString();
            target.gameObject.SetActive(false);
        }
        if (target.tag == "Rock")
        {
            transform.position = new Vector3(0, 1000, 0);
            target.gameObject.SetActive(false);
            StartCoroutine(RestartGame());
        }
    }
    IEnumerator RestartGame()
        {
            yield return new WaitForSecondsRealtime(2f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
}