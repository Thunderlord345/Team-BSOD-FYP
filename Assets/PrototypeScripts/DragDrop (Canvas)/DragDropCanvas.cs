using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDropCanvas : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    //private RectTransform rectTrans;

    //[SerializeField] Canvas canvas;
    //private CanvasGroup canvasGroup;

    public Image image;
    [HideInInspector] public Transform parentAfterDrag;
    private void Awake()
    {
       
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        transform.position = Input.mousePosition;
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("PointerDown");
        //throw new System.NotImplementedException();
    }

    public void OnDrop(PointerEventData eventData)
    {

    }
}

    

