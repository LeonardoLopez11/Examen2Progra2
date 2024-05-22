using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public int damage = 10;

    void OnCollisionEnter(Collision collision)
    {
        JugadorVida jugadorvida = collision.gameObject.GetComponent<JugadorVida>();
        if (jugadorvida != null)
        {
            jugadorvida.TakeDamage(damage);
        }

        
        Destroy(gameObject);
    }
}

