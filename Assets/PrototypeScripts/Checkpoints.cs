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

    // Start is called before the first frame update
    void Start()
    {
        switch (checkpoints)
        {
            case Checkpoint.c1:
                panel.SetActive(true);
                break;
            case Checkpoint.c2:
                panel.SetActive(true);
                break;
            case Checkpoint.c3:
                panel.SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {

        }
    }
}
