using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Animator anim;
    public float speed;
    Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            anim.SetTrigger("Run");
        }
    }
}

