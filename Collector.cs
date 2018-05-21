using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour {

    private float width = 0f;

	void Awake ()
    {
        width = GameObject.Find("BG").GetComponent<BoxCollider2D>().size.x;
	}
	
	void OnTriggerEnter2D (Collider2D target)
    {
        if (target.tag == "BG" || target.tag == "Ground" || target.tag == "FG")
        {
            Vector3 temp = target.transform.position;
            temp.x += width * 3;
            target.transform.position = temp;
        }
        if (target.tag == "Banana" || target.tag == "Rock")
        {
            target.gameObject.SetActive(false);
        }
	}
}
