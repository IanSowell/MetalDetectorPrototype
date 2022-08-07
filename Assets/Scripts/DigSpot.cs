using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigSpot : MonoBehaviour
{
    private TreasureItem earnedTreasure;
    private int value;
    private int maxStage = 3;
    public int digStage;
    private int clampedDigStage;
    public bool isGoodTreasure;
    private bool hasCompletedDigging = false;
    private void OnEnable()
    {
        digStage = 1;
        //Set what item is earned when the player digs up the spot from a list of items
    }
    private void Start()
    {
        if (isGoodTreasure)
        {
            int rand = Random.Range(0, DigSpotCreator.instance.treasure.Capacity);//get random item from treasure
            earnedTreasure = DigSpotCreator.instance.treasure[rand];
        }
        else
        {
            int rand = Random.Range(0, DigSpotCreator.instance.falseTreasure.Capacity);//get random item from false treasure
            earnedTreasure = DigSpotCreator.instance.falseTreasure[rand];
        }
        value = earnedTreasure.value;
        GetComponent<MeshRenderer>().material = earnedTreasure.model.GetComponent<MeshRenderer>().sharedMaterials[digStage];
        //CompletedDigSpot();
    }
    private void Update()
    {
        clampedDigStage = Mathf.Clamp(digStage, 0, maxStage);
        if(clampedDigStage == maxStage && !hasCompletedDigging)
        {
            CompletedDigSpot();
        }
    }

    public void CompletedDigSpot() {
        //give the player a treasure or something
        MoneyHandler.instance.UpdateMoney(value);
        hasCompletedDigging = true;
    }
}
