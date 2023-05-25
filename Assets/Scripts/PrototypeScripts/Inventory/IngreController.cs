using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngreController : MonoBehaviour
{
    public Ingredients ingredient;

    private SpriteRenderer spriteRenderer;
    private Sprite itemImage => ingredient.image;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = itemImage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
