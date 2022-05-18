using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Die : MonoBehaviour
{
    public float hp = 100f;
    public Slider hpslider;

    private void Update()
    {
        hpslider.value = hp;
        if (hp <= 0)
        {
            Lose();
        }
    }

    public void TakeDamage()
    {
        
            hp -= 10;
        
       
    }

    private void Lose()
    {
        SceneManager.LoadScene("DieScene");
    }

    
    
}
