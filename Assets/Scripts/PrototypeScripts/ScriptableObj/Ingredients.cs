using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Ingredients", menuName = "NewIngredients/Ingredient")]
public class Ingredients : ScriptableObject
{
    public enum Type
    {
        A, B, C, D, E, F, G, H, I, J, K, L
    };

    public Type type;
    public Sprite image;
    public string name;
    public string description;
}
