using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyB : EnemyBase
{

    public GameObject enemyBulletPrefab;
    public Transform firePoint;

    void Start()
    {
        bulletType = "White"; 
    }

    public override void Move()
    {
        
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }

    public override void Shoot()
    {
        
        if (enemyBulletPrefab != null && firePoint != null)
        {
            Instantiate(enemyBulletPrefab, firePoint.position, Quaternion.LookRotation(Vector3.down));
        }
    }
}
