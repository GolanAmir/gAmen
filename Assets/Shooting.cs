using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 35f;
    public float FireRate = 10f;  // The number of bullets fired per second
    private float lastfired = 0f ;      // The value of Time.time at the last firing moment


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if ((Time.time - lastfired) > (1 / FireRate))
            {
                lastfired = Time.time;
                Shoot();
            }
        }

    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
