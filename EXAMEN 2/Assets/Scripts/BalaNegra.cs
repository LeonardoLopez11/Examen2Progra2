using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaNegra : ProyectilBase
{
    // Start is called before the first frame update
    void Start()
    {
        Shoot(Vector3.forward, speed);
    }

    public override void Shoot(Vector3 direction, float speed)
    {
        Move(direction);
    }
}
