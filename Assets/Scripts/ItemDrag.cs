using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrag : MonoBehaviour
{

    Vector3 offset;
    bool isDragging = false;


    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        }
       
        isDragging = true;
        print("mousedown");
    }

    private void OnMouseDrag()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = new Vector3(curPosition.x, curPosition.y, transform.position.z); //setting the item to cursor position 
            print("mousedrag");

        }
        
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }

}
