using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorRadius : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TreasureSpot"))
        {
            MetalDetector.script.DetectedTreasure(true);//Do Something to signify treasure in location
        }
    }
    private void OnTriggerExit(Collider other)
    {
        MetalDetector.script.DetectedTreasure(false);
    }
}
