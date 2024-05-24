using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyA : EnemyBase
{
    public GameObject enemyBulletPrefab;
    public Transform firePoint;

    void Start()
    {
        bulletType = "Black"; 
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
