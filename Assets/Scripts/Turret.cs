using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turret : MonoBehaviour
{
    public GameObject target;
    [Header("Attributes")] 
    
    public float range = 10f;
    public float firerate = 1f;
    private float firecountdown = 0f;
    [SerializeField] private GameObject bulletprefab;
    public Transform firePoint;
    
    private void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
    private void Update()
    {
        if (target == null) return;
        if (firecountdown<= 0f)
        {
            Shoot();
            firecountdown = 1 / firerate;
        }
        firecountdown -= Time.deltaTime;
    }
    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float closestDistance = Mathf.Infinity;
        GameObject nearestenemy = null;
        foreach (GameObject enemy in enemies)
        {
            float EnemyDistance = Vector3.Distance(transform.position, enemy.transform.position);
            if(EnemyDistance < closestDistance)
            {
                closestDistance = EnemyDistance;
                nearestenemy = enemy;
            }
        }
        if(nearestenemy != null && closestDistance <= range)
        {
            target = nearestenemy;
        }
        else
        {
            target = null;
        }
    }
    void Shoot()
    {
      
        GameObject bulletGo = (GameObject)Instantiate(bulletprefab, firePoint.position, firePoint.rotation);
        bullet bullet = bulletGo.GetComponent<bullet>();
        if(bullet != null)
        {
            bullet.Follow(target.transform);
            bullet.CurrentEnemy(target);
        }
    }
    
}
