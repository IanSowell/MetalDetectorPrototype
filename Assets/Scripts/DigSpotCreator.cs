using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigSpotCreator : MonoBehaviour
{
    [SerializeField] private GameObject DiggingSpot;
    [SerializeField] private GameObject Shovel;

    [SerializeField] private GameObject ground;
    public static DigSpotCreator instance;
    public List<TreasureItem> treasure;
    public List<TreasureItem> falseTreasure;
    //Spawn diggingspot when the shovel hits a point on the ground beyond a minimum velocity;
    private void Start()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void SpawnDigSpot(Vector3 digLocation, bool isGoodTreasure)
    {
        GameObject instancedObject = Instantiate(DiggingSpot, new Vector3(digLocation.x, digLocation.y, digLocation.z), DiggingSpot.transform.rotation);
        instancedObject.GetComponent<DigSpot>().isGoodTreasure = isGoodTreasure;//set the instantiated digspot's treasure value to what was given
    }
}
