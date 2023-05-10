using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartHouse : MonoBehaviour
{
    public GameObject Panel;
    public GameObject shopPanel;
    public GameObject reqPanel;
    public GameObject rewardPanel;
    

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
            Panel.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Panel.SetActive(false);
        }

    }

    public void Request()
    {
        reqPanel.SetActive(true);
    }

    public void Shop()
    {
        shopPanel.SetActive(true);
    }

    public void Achi()
    {
        rewardPanel.SetActive(true);
    }

    public void Back()
    {
        //close the current tab 
        GameObject.Find("Back").GetComponent<Button>().transform.parent.gameObject.SetActive(false);
    }


}
