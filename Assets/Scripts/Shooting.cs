using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform Player;
    public Transform muzzle;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Animator animator;
    public int shooterCounter; 

    public float bulletForce = 30f;
    public float FireRate = 2f;  // The number of bullets fired per second
    private float lastfired = 0f ;      // The value of Time.time at the last firing moment

 
    Vector3 temp = new Vector3(0, 0.3f, 0);
    //Vector3 temp2 = 
    
    
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
        if(shooterCounter == 0)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

            Vector3 direction = new Vector3(animator.GetFloat("Horizontal"), animator.GetFloat("Vertical"), 0f);

            rb.AddForce(direction * bulletForce, ForceMode2D.Impulse);
        }

        if(shooterCounter == 1)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position + temp, Quaternion.identity);
            GameObject bullet1 = Instantiate(bulletPrefab, firePoint.position - temp, Quaternion.identity);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            Rigidbody2D rb1 = bullet1.GetComponent<Rigidbody2D>();

            Vector3 direction = new Vector3(animator.GetFloat("Horizontal"), animator.GetFloat("Vertical"), 0f);

            rb.AddForce(direction * bulletForce, ForceMode2D.Impulse);
            rb1.AddForce(direction * bulletForce, ForceMode2D.Impulse);
        }

        if (shooterCounter == 2)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position + temp, Quaternion.identity);
            GameObject bullet1 = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            GameObject bullet2 = Instantiate(bulletPrefab, firePoint.position - temp, Quaternion.identity);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            Rigidbody2D rb1 = bullet1.GetComponent<Rigidbody2D>();
            Rigidbody2D rb2 = bullet1.GetComponent<Rigidbody2D>();

            Vector3 direction = new Vector3(animator.GetFloat("Horizontal"), animator.GetFloat("Vertical"), 0f);

            rb.AddForce(direction * bulletForce, ForceMode2D.Impulse);
            rb1.AddForce(direction * bulletForce, ForceMode2D.Impulse);
            rb2.AddForce(direction * bulletForce, ForceMode2D.Impulse);
        }

    }

    public void setFireRate(float newRate)
    {
        FireRate = newRate;
    }

    public void setBulletForce(float newBF)
    {
        bulletForce = newBF;
    }

    public void setShooterCounter(int newSC)
    {
        shooterCounter = newSC;
    }
}
