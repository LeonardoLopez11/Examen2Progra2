using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 50;
    public float lifeTime = 3f; 

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = -transform.up * speed; 
        Destroy(gameObject, lifeTime); 
    }

    void OnCollisionEnter(Collision collision)
    {
        JugadorVida jugadorvida = collision.gameObject.GetComponent<JugadorVida>();
        if (jugadorvida != null)
        {
            jugadorvida.TakeDamage(50);
        }

        
        
    }

}

