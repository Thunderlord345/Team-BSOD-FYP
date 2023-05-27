using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Linq;

public class EventManager : MonoBehaviour
{

    public UnityEvent ingreSpawn;
    public GameObject[] ingre; //spawning this 
    public Transform[] spawn; //location 
    //public Event weatherSpawn;

    public void SpawnIngre()
    {
        for(int i = 0; i < ingre.Length; i++)
        {

            //Transform spawnPoint = spawn[i];
            int randomObjectIndex = Random.Range(0, ingre.Length);
            //int randomSpawnIndex = Random.Range(0, spawn.Length);

            GameObject ingreSpawn = Instantiate(ingre[randomObjectIndex], spawn[randomObjectIndex].position, Quaternion.identity);
            ingreSpawn.transform.position = spawn[randomObjectIndex].position;

            RemoveSpawnPoint(randomObjectIndex);
            RemoveObject(randomObjectIndex);


        }
        //foreach(GameObject obj in ingre)
        //{
        //    Instantiate(obj, spawn);
        //}
        //Instantiate(ingre, spawn);
        print("spawn");
    }

    void RemoveSpawnPoint(int index)
    {
        Transform[] newSpawn = new Transform[spawn.Length - 1];

        for(int i = 0, j = 0; i < spawn.Length; i++)
        {
            if(i != index)
            {
                newSpawn[j] = spawn[i];
                j++;
            }
        }

        spawn = newSpawn;
    }

    void RemoveObject(int index)
    {
        GameObject[] newIngre = new GameObject[ingre.Length - 1];

        for (int i = 0, j = 0; i < ingre.Length; i++)
        {
            if (i != index)
            {
                newIngre[j] = ingre[i];
                j++;
            }
        }

        ingre = newIngre;
    }
}
