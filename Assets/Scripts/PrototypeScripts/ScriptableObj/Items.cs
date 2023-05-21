using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Items", menuName = "NewItems/Item")]
public class Items : ScriptableObject
{
    public Sprite image;
    public string name;
    public string description;
    public int cost;
}
