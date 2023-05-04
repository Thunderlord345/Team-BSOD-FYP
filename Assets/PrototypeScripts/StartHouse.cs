using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartHouse : MonoBehaviour
{
    GameObject shopPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            shopPanel.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            shopPanel.SetActive(false);
        }

    }

    public void Request()
    {

    }

    public void Shop()
    {

    }

    public void Achi()
    {

    }


}
