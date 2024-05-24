using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaBlanca : ProyectilBase
{
    public float lifeTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Shoot(Vector3.forward, speed);
        Destroy(gameObject, lifeTime);
    }

    public override void Shoot(Vector3 direction, float speed)
    {
        Move(direction);
    }
    void OnCollisionEnter(Collision collision)
    {
        
        Ienemy ienemy = collision.gameObject.GetComponent<Ienemy>();
        if (ienemy != null)
        {
            ienemy.TakeDamage(100, "White"); 
        }
        
    }
}
