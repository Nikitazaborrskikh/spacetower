using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private Transform m_Target;
    private NavMeshAgent agent;
    private Slider _slider;
    private float health = 100f;
    private GameObject gamemanager;
    private PlayerStats coinsplus;
    private GameObject  Base;
    private Die die;

    private void Awake()
    {
        _slider = GetComponentInChildren<Slider>();
        Base = GameObject.FindWithTag("Base");
        die = Base.GetComponent<Die>();
       gamemanager = GameObject.FindWithTag("GameController");
       coinsplus = gamemanager.GetComponent<PlayerStats>();
        agent = GetComponent<NavMeshAgent>();
        m_Target = GameObject.FindWithTag("Base").transform;
    }
    private void Update()
    {
        agent.destination = m_Target.position;
        if(Vector3.Distance(agent.transform.position, agent.destination) < 2f)
        {
            Die();
            die.TakeDamage();
        }

        
       
        
    }

    public void FreezeSpeed()
    {
        
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        _slider.value = health;
        
        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        coinsplus.EnemyKill();
        Destroy(this.gameObject);
    }

    IEnumerator FreezeTime()
    {
        yield return new WaitForSeconds(2);
    }

}
