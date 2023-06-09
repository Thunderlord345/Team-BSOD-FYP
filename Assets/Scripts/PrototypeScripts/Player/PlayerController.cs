using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    Rigidbody2D rb;
    float walkSpeed = 4f;
    public bool goFoward;
    Vector2 moveFoward;



    public enum Walk
    {
        Manual,
        Auto
    }

    public Walk walk;

    string walkChoice;

    public GameObject transPanel;

    SpawnManager eventManager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        eventManager = FindObjectOfType<SpawnManager>();

        switch (walk)
        {
            case Walk.Manual:
                walkChoice = "man";
                break;
            case Walk.Auto:
                walkChoice = "auto";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //player key movement 
        if (walkChoice == "man")
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

        else if(walkChoice == "auto")
        {
            if (goFoward == true)
            {
                moveFoward = gameObject.transform.position;
                moveFoward.x += walkSpeed * Time.deltaTime;
                gameObject.transform.position = moveFoward;
            }
        }
       
    }

    public void PlayGame()
    {
        goFoward = true; //for button 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Spawn")
        {
            eventManager.ingreSpawn.Invoke();
            print("spawning event");
            Destroy(collision.gameObject.GetComponent<BoxCollider2D>());
        }
    }
}
