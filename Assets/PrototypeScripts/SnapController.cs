using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapController : MonoBehaviour
{
    public List<Transform> snapPoints;
    public List<ItemDrag> draggableObj;
    public float snapRange = 0.5f;


    public GameObject[] draggables;
    public GameObject[] slots;


    Rigidbody2D[] rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponents<Rigidbody2D>();

        for (int i = 0; i < slots.Length; i++)
        {
            draggables[i].transform.localPosition = slots[i].transform.localPosition;
        }


        foreach (ItemDrag draggable in draggableObj)
        { 
            draggable.dragEndedCallBack = OnDragEnded;
        }

       
    }

    void OnDragEnded(ItemDrag draggable)
    {
        float closestDistance = -1; //item closest to snappoint;
        Transform closestSnapPoint = null;

        foreach(Transform snapPoint in snapPoints)
        {
            //get the distance between snappoint and item 
            float currentDistance = Vector2.Distance(draggable.transform.localPosition, snapPoint.localPosition);

            //if snapPoint is empty and nearest to snapPoint it snaps
            if(closestSnapPoint == null || currentDistance < closestDistance)
            {
                closestSnapPoint = snapPoint;
                closestDistance = currentDistance;
            }
        }

        //snapping it 
        if(closestSnapPoint && closestDistance <= snapRange)
        {
            draggable.transform.localPosition = closestSnapPoint.localPosition;
        }

        //resetting it if doesnt snap 
        else
        {

            //for (int i = 0; i < slots.Length; i++)
            //{
            //    draggables[i].transform.localPosition = slots[i].transform.localPosition;
            //}

        }
    }
}
