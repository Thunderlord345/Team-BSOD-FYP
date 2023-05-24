using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngrePickup : MonoBehaviour
{
    //public Items item;
    public Ingredients ingredient;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pickup()
    {
        InventoryManager.Instance.Add(ingredient);
        Destroy(gameObject);
    }

    //private void OnMouseDown()
    //{
    //    Pickup();
    //}
}
