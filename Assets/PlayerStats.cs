using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public Text MoneyUI;
    public int startMoney = 400;

    private void Start()
    {
        Money = startMoney;
        StartCoroutine(AddCoins());
    }
    

    private void Update()
    {
       
        MoneyUI.text = Money.ToString();
    }

    public void EnemyKill()
    {
        Money += 10;
    }

    IEnumerator AddCoins()
    {
        while (true)
        {
            Money ++;
            yield return new WaitForSeconds(1);
        }
        
        
    }
}
