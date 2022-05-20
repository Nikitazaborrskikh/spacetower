using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bullet : MonoBehaviour
{
    private Transform target;
    private GameObject enemy;
    public float speed = 70f;
    private Enemy enemyhp;
    public float damage = 20;
    public bool isfrezing = false;
    
    
    private void Start()
    {
      
    }

    public void Follow (Transform _target)
    {
        target = _target;
        
    }

    public void CurrentEnemy(GameObject _enemy)
    {
        enemy = _enemy;
    }
    private void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 dir = target.position - transform.position; 
        float distThisFrame = speed * Time.deltaTime;
        if(dir.magnitude <= distThisFrame + 1)
        {
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distThisFrame, Space.World);
       void HitTarget()
       {
           
               Damage(enemy);
           
           
           
          
           Destroy(gameObject);
           
           
       }

       void Damage(GameObject _enemy)
       {
        Enemy enemyhp =  _enemy.GetComponent<Enemy>();
        enemyhp.TakeDamage(damage);
        
       }

       void Freeze(GameObject _enemy)
       {
           Enemy enemyhp =  _enemy.GetComponent<Enemy>();
           
       }
       
    }
}
