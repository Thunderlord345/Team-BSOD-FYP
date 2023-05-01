using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    float walkSpeed = 3f;
    public bool goFoward;
    Vector2 moveFoward;

    Checkpoints checkpoint;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        checkpoint = FindObjectOfType<Checkpoints>();
    }

    // Update is called once per frame
    void Update()
    {
        //player key movement 
        //if (Input.GetAxisRaw("Horizontal") > 0) // moving right 
        //{
        //    rb.velocity = new Vector2(walkSpeed, rb.velocity.y);

        //}
        //else if (Input.GetAxisRaw("Horizontal") < 0) //moving left 
        //{
        //    rb.velocity = new Vector2(-walkSpeed, rb.velocity.y);

        //}
        //else
        //{
        //    rb.velocity = new Vector2(0, rb.velocity.y); //staying still 
        //}

        if (goFoward == true)
        {
            moveFoward = gameObject.transform.position;
            moveFoward.x += walkSpeed * Time.deltaTime;
            gameObject.transform.position = moveFoward;

           
        }

       
    }

    public void PlayGame()
    {
        goFoward = true; //for button 
        Debug.Log("moving");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Checkpoint")
        {
            //if(checkpoint.checkpoint.c1)
        }
    }
}
