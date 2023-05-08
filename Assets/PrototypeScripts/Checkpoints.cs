using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoints : MonoBehaviour
{
    PlayerController player;
    public enum Checkpoint
    {
        c1,
        c2,
        c3
    }
    public Checkpoint checkpoints;

    public GameObject panel;
    public GameObject move;
    public GameObject progBar;
    public GameObject back;

    bool isTriggered = false; //disable opening again

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
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
            move.SetActive(false);
            progBar.SetActive(false);
            player.goFoward = false;
            back.SetActive(true);
        }
    }

    public void Back()
    {
        panel.SetActive(false); //for button to deactivate
        move.SetActive(true);
        progBar.SetActive(true);
        player.goFoward = true;
        back.SetActive(true);

    }
}
