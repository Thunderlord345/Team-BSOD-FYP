using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
//using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public TMP_Text moneyUI;
    int money; //money in game 
    //Text amount;
    

    // Start is called before the first frame update
    void Start()
    {
        money = 100; 
        moneyUI.text = "$" + money.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Purchase()
    {
        //Once pressed money reduce

        //item get added into a slot 


    }
}
