using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float walkSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0) // moving right 
        {
            rb.velocity = new Vector2(walkSpeed, rb.velocity.y);
            
        }
        else if (Input.GetAxisRaw("Horizontal") < 0) //moving left 
        {
            rb.velocity = new Vector2(-walkSpeed, rb.velocity.y);
            
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y); //staying still 
        }
    }
}
