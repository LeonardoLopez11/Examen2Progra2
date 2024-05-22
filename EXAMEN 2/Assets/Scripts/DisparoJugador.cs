using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour
{
    public GameObject blackBulletPrefab;
    public GameObject whiteBulletPrefab;
    public Transform firePoint;
    public float fireRate = 0.5f;
    public float projectileSpeed = 10f;

    private float nextFireTime = 0f;
    private GameObject currentBulletPrefab;

    void Start()
    {
        currentBulletPrefab = blackBulletPrefab; 
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentBulletPrefab = blackBulletPrefab;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentBulletPrefab = whiteBulletPrefab;
        }
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(currentBulletPrefab, firePoint.position, firePoint.rotation);
        Iproyectil projectileScript = projectile.GetComponent<Iproyectil>();
        if (projectileScript != null)
        {
            projectileScript.Shoot(Vector3.forward, projectileSpeed);
        }
    }
}
