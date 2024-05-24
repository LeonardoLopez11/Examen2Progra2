using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorVida : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;


    void Start()
    {
        currentHealth = maxHealth;
       
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        

        if (currentHealth <= 0)
        {
            Die();
        }
    }


    void Die()
    {

        Trophies.Unlock(233911);
        Destroy(gameObject);
    }
}
