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
    
    private void Awake()
    {
        _slider = GetComponentInChildren<Slider>();
       
        agent = GetComponent<NavMeshAgent>();
        m_Target = GameObject.FindWithTag("Base").transform;
    }
    private void Update()
    {
        agent.destination = m_Target.position;
        if(Vector3.Distance(agent.transform.position, agent.destination) < 2f)
        {
            Die();
        }

        
       
        
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
        Destroy(this.gameObject);
    }

}
