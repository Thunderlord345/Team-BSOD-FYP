using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrag : MonoBehaviour
{
    public delegate void DragEnded(ItemDrag draggableObj);

    public DragEnded dragEndedCallBack;

    bool isDragging = false;
    Vector3 mouseDragStartPos;
    Vector3 spriteDragStartPos;

    Rigidbody2D rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void OnMouseDown()
    {
        isDragging = true;
        mouseDragStartPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //get mouse position in camera 
        spriteDragStartPos = transform.localPosition;
    }

    private void OnMouseDrag()
    {
        if (isDragging)
        {
            transform.localPosition = spriteDragStartPos + (Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseDragStartPos);
        }
    }

    private void OnMouseUp()
    {
        isDragging = false;
        dragEndedCallBack(this);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Slot")
        {
            rb.bodyType = RigidbodyType2D.Kinematic;
            rb.velocity = Vector3.zero;
        }


       
    }

    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.tag == "Slot")
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }


        
    }

}
