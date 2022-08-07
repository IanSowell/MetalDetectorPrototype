using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject SpawnLocation;
    public List<GameObject> itemToSpawn;

    public void SpawnItem(int item)
    {
        Instantiate(itemToSpawn[item], SpawnLocation.transform.position, SpawnLocation.transform.rotation) ;
    }
}
