using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Animator animator;

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
                //animator.SetBool("Shooting", true);
                animator.PlayInFixedTime("Shooting Standing");
                Shoot();  
            }
        }
        animator.pla

    }

    void Shoot()
    {
        //Vector2 sDirection = Input.mousePosition;
        //sDirection.Normalize();

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        Vector3 direction = new Vector3(animator.GetFloat("Horizontal"), animator.GetFloat("Vertical"), 0f);

        rb.AddForce( direction * bulletForce, ForceMode2D.Impulse);


    }
}
