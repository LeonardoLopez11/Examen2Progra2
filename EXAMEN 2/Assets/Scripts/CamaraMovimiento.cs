using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovimiento : MonoBehaviour
{
    public float scrollSpeed = 5f;

    void Update()
    {
        transform.position += new Vector3(0, 0, scrollSpeed * Time.deltaTime);
    }
}
