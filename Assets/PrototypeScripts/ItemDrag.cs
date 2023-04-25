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

}
