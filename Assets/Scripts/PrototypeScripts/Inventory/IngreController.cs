using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngreController : MonoBehaviour
{
    public Ingredients ingredient;

    private Sprite itemImage => ingredient.image;
    // Start is called before the first frame update
    void Start()
    {
        //image.sprite = itemImage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
