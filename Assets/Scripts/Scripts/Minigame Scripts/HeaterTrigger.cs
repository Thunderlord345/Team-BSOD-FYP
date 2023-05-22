using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeaterTrigger : MonoBehaviour
{
    public bool white, yellow, orange, green, red;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "White")
        {
            white = true;
            yellow = orange = green = red = false;
            print("White");
        } else if(other.tag == "Yellow")
        {
            yellow = true;
            white = orange = green = red = false;
            print("Yellow");
        }
        else if (other.tag == "Orange")
        {
            orange = true;
            white = yellow = green = red = false;
            print("Orange");
        }
        else if (other.tag == "Green")
        {
            green = true;
            white = orange = yellow = red = false;
            print("Green");
        }
        else if (other.tag == "Red")
        {
            red = true;
            white = orange = green = yellow = false;
            print("Red");
        }
    }
}
