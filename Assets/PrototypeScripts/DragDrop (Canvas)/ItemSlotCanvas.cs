using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlotCanvas : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        //Snapping
        GameObject dropped = eventData.pointerDrag;
        DragDropCanvas draggableItem = dropped.GetComponent<DragDropCanvas>();
        draggableItem.parentAfterDrag = transform;
    }
}
