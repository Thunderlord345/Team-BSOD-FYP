using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public TMP_Text moneyUI;  //Text amount;
    int money; //money in game 

    public Button purchaseBut; //purchase button 

    // Start is called before the first frame update
    void Start()
    {
        money = 100;
        UpdateBank();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Purchase()
    {
        //After purchasing money goes down 
        money -= 10; //reduce by 10
        purchaseBut.interactable = false;
        UpdateBank();


        //item get added into a slot 

    }

    void UpdateBank() //making sure new amount is updated 
    {
        moneyUI.text = "$" + money.ToString();
    }

    public void Back()
    {
        //close the current tab 
        GameObject.Find("Back").GetComponent<Button>().transform.parent.gameObject.SetActive(false);
    }
}
