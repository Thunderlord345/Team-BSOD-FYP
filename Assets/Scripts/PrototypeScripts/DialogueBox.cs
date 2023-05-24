using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueBox : MonoBehaviour
{

    public GameObject inventoryPanel;
    bool isOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenBackpack()
    {
        isOpen = !isOpen;

        if (!isOpen)
        {
            inventoryPanel.SetActive(true);
        }

        else if (isOpen)
        {
            inventoryPanel.SetActive(false);
        }
        
        

    }
}
