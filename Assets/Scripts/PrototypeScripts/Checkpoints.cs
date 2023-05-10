using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public enum Checkpoint
    {
        c1,
        c2,
        c3
    }
    public Checkpoint checkpoints;

    public GameObject panel;

    bool isTriggered = false; //disable opening again

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" && !isTriggered) //only open if triggered is not true
        {
            print("openingPanel");
            isTriggered = true;
            panel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Back()
    {
        panel.SetActive(false); //for button to deactivate
        Time.timeScale = 1;

    }
}
