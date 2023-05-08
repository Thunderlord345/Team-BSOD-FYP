using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropCanvas : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    private RectTransform rectTrans;

    [SerializeField] Canvas canvas;
    private void Awake()
    {
        rectTrans = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectTrans.anchoredPosition += eventData.delta / canvas.scaleFactor; //Move image
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
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

    

