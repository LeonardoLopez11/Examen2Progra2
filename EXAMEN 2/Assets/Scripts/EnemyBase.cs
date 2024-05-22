using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour , Ienemy
{
    public int maxHealth = 100;
    protected int currentHealth;

    public float moveSpeed = 5f;
    public float fireRate = 1f;
    protected float nextFireTime = 0f;

    public string bulletType; 

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        Move();
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    public abstract void Move();

    public abstract void Shoot();

    public void TakeDamage(int amount, string bulletType)
    {
        if (this.bulletType == bulletType)
        {
            currentHealth -= amount;
            currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

            if (currentHealth <= 0)
            {
                Die();
            }
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

}
