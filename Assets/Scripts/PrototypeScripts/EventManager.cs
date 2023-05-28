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


        int randomObjectIndex = Random.Range(0, ingre.Length); //pick a random obj in the list 
        
        if(spawnIndex >= ingre.Length || spawnIndex >= spawn.Length)
        {
            spawnIndex = 0; //making sure it does not exceed the available spawn or obj
        }

        GameObject ingreSpawn = Instantiate(ingre[randomObjectIndex], spawn[spawnIndex].position, Quaternion.identity);
        print(ingreSpawn);
        ingreSpawn.transform.position = spawn[spawnIndex].position;

        RemoveSpawnPoint(spawnIndex);
        RemoveObject(randomObjectIndex);
    }

    void RemoveSpawnPoint(int index)
    {
        var newSpawn = new List<Transform>(spawn);
        newSpawn.RemoveAt(index);
        spawn = newSpawn.ToArray();
    }

    void RemoveObject(int index)
    {
        var newIngre = new List<GameObject>(ingre);
        newIngre.RemoveAt(index);
        ingre = newIngre.ToArray();
    }
}
