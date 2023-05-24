using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Ingredients> Ingredients = new List<Ingredients>();

    public Transform IngredientContent;
    public GameObject InventoryIngredient;
    private void Awake()
    {
        Instance = this;
    }
  
    public void Add(Ingredients ingredient)
    {
        Ingredients.Add(ingredient);
    }

    public void Remove(Ingredients ingredient)
    {
        Ingredients.Remove(ingredient);
    }

    public void ListIngre()
    {
        foreach(var ingredient in Ingredients)
        {
            GameObject obj = Instantiate(InventoryIngredient, IngredientContent);
            var ingredientName = obj.transform.Find("ItemName").GetComponent<Text>();
            var ingredientIcon = obj.transform.Find("ItemImage").GetComponent<Image>();

            ingredientName.text = ingredient._name;
            ingredientIcon.sprite = ingredient.image;
        }
    }
}
 