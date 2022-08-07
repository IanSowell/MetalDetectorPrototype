using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Item", menuName = "ScriptableObjects/TreasureItem")]
public class TreasureItem : ScriptableObject
{
    public string itemName;
    public int itemID;
    public int value;
    public GameObject model;
}
