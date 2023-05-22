using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientData : MonoBehaviour
{
    public Ingredients ingredient;

    //setting the details 
    private string itemName => ingredient._name;
    private Sprite itemImage => ingredient.image;
    private string itemDesc => ingredient.description;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
