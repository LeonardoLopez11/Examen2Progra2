using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ProyectilBase : MonoBehaviour, Iproyectil
{
    public float speed = 10f;

    public abstract void Shoot(Vector3 direction, float speed);

    protected void Move(Vector3 direction)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = direction * speed;
    }
}
