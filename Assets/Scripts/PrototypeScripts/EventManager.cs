using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{

    public UnityEvent ingreSpawn;
    public GameObject ingre; //spawning this 
    public Transform spawn; //location 
    //public Event weatherSpawn;


    public void SpawnIngre()
    {
        Instantiate(ingre, spawn);
        print("spawn");
    }

}
