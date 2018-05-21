using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{

    private float speed = 3f;

    private Rigidbody2D myBody;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;
        if (Input.GetKeyDown("down"))
        {
            Jump();
        }

    }

    void Jump()
    {
        myBody.gravityScale *= -1;
        Vector3 temp = myBody.transform.localScale;
        temp.y *= -1;
        myBody.transform.localScale = temp;
    }
}
