using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    public float speed = 5f;   
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * speed;

        GetComponent<Rigidbody2D>().velocity = Vector2.right * h;
    }
}
