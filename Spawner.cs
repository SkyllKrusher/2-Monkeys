using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    [SerializeField]
    private GameObject[] items;

    private float maxY = 3.2f, minY = 0.6f;
	// Use this for initialization
	void Start ()
    {
        StartCoroutine(SpawnItems(1f));
    }
	
	// Update is called once per frame
    IEnumerator SpawnItems(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        Vector3 temp;
        temp = new Vector3(transform.position.x, Random.Range(minY, maxY), 0);
        Instantiate(items[Random.Range(0, items.Length)], temp, Quaternion.identity);
        temp = new Vector3(transform.position.x, Random.Range(-minY, -maxY), 0);
        Instantiate(items[Random.Range(0, items.Length)], temp, Quaternion.identity);
        StartCoroutine(SpawnItems(Random.Range(1f, 2f)));
    }
}
