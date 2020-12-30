using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Animator animator;

    public float bulletForce = 30f;
    public float FireRate = 2f;  // The number of bullets fired per second
    private float lastfired = 0f ;      // The value of Time.time at the last firing moment


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            animator.SetBool("Shooting", true);
            if ((Time.time - lastfired) > (1 / FireRate))
            {
                lastfired = Time.time;
                //animator.PlayInFixedTime("Shooting Standing");
                Shoot(); 
            }
        } else
        {
            animator.SetBool("Shooting", false);
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        Vector3 direction = new Vector3(animator.GetFloat("Horizontal"), animator.GetFloat("Vertical"), 0f);

        rb.AddForce( direction * bulletForce, ForceMode2D.Impulse);

    }

    public void setFireRate(float newRate)
    {
        FireRate = newRate;
    }

    public void setBulletForce(float newBF)
    {
        bulletForce = newBF;
    }
}
