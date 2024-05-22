using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Ienemy 
{
    void TakeDamage(int amount, string bulletType);
    void Move();
    void Shoot();

}
