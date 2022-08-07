using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoneyHandler : MonoBehaviour
{
    public static MoneyHandler instance;
    public float currentMoney;
    [SerializeField] private TextMeshProUGUI moneyDisplay;

    private void Start()
    {
        instance = this;
    }
    private void Update()
    {
        moneyDisplay.text = $"${currentMoney}";
    }
    public void UpdateMoney(float newMoney)
    {
        currentMoney += newMoney;
    }
}
