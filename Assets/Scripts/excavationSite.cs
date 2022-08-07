using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class excavationSite : MonoBehaviour
{
    private Vector3 squarePos;  //world position of your square
    private Vector3 squareSize; //x = width, y = height, z = length of box
    public float squareBorder; //how far away from the edges you want the spawn to stay
    Vector3 realSquareSize;

    public int objectAmount; //how many you want to spawn
    public GameObject instantiatedObject;


    void Awake()
    {
        squarePos = gameObject.transform.position;
        squareSize.x = gameObject.transform.localScale.x/2;
        squareSize.y = gameObject.transform.localScale.y/2;
        squareSize.z = gameObject.transform.localScale.z/2;
        realSquareSize = squareSize - (Vector3.one * squareBorder);
        for(int i = 0; i <= objectAmount; i++)
            SpawnPrefabOnSquare(instantiatedObject);
    }
    public void SpawnPrefabOnSquare(GameObject thePrefabYouWantToSpawn)
    {
        var spawnPos = squarePos + new Vector3(Random.Range(-realSquareSize.x, realSquareSize.x), Random.Range(-realSquareSize.y, realSquareSize.y), Random.Range(-realSquareSize.z, realSquareSize.z));
        Instantiate(thePrefabYouWantToSpawn, spawnPos, Quaternion.identity);
    }
}
