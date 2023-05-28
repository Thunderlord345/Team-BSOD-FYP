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

    int spawnIndex = 0; 

    public void SpawnIngre()
    {
        //check that there's still obj to spawn at a location 
        if (ingre.Length == 0 || spawn.Length == 0)
            return;

        //making sure it does not exceed the available spawn or obj
        if (spawnIndex >= ingre.Length || spawnIndex >= spawn.Length)
        {
            spawnIndex = 0; 
        }

        int randomObjectIndex = Random.Range(0, ingre.Length); //pick a random obj in the list 

        GameObject ingreSpawn = Instantiate(ingre[randomObjectIndex], spawn[spawnIndex].position, Quaternion.identity);
        ingreSpawn.transform.position = spawn[spawnIndex].position; //set the spawned obj to the spawner location 

        RemoveSpawnPoint(spawnIndex);
        RemoveObject(randomObjectIndex);
    }

    void RemoveSpawnPoint(int index)
    {
        var newSpawn = new List<Transform>(spawn);
        newSpawn.RemoveAt(index); //remove transform that was used 
        spawn = newSpawn.ToArray(); //set the new list 
    }

    void RemoveObject(int index)
    {
        var newIngre = new List<GameObject>(ingre);
        newIngre.RemoveAt(index); 
        ingre = newIngre.ToArray();
    }
}
