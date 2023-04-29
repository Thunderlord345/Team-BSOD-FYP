using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = FindObjectOfType<Rigidbody2D>();
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ingredient")
        {
            rb.bodyType = RigidbodyType2D.Kinematic;
            rb.velocity = Vector3.zero;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Ingredient")
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            //rb.velocity = Vector3.zero;
        }
    }
}
