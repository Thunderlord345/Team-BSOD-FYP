using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IngredientData : MonoBehaviour
{
    public Ingredients ingredient;
    public TextMeshProUGUI _name;
    public Image image;
    
    
    //setting the details 
    private string itemName => ingredient._name;
    private Sprite itemImage => ingredient.image;
    private string itemDesc => ingredient.description;

    // Start is called before the first frame update
    void Start()
    {
        _name.text = itemName;
        image.sprite = itemImage;
        print(itemName);
        print(itemDesc);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
