using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Items", menuName = "NewItems/Item")]
public class Items : ScriptableObject
{
    public enum Item
    {
        //all items 
    }

    public Item item; //so things can refer to this
    public Sprite image;
    public string _name;
    public string description;
    public int cost;
}
