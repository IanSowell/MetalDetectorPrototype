using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalDetector : MonoBehaviour
{
    public static MetalDetector script;
    private bool hasDetectedTreasure;
    public GameObject lightDetector;

    private void Awake()
    {
        script = this;
    }
    public void DetectedTreasure(bool detectTreasure)
    {
        hasDetectedTreasure = detectTreasure;
        lightDetector.SetActive(hasDetectedTreasure);
    }
}
