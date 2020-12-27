using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
   
    void OnCollisionEnter2D(Collision2D collision)
    {
        Quaternion collisionDir = transform.rotation;
        GameObject effect = Instantiate(hitEffect, transform.position, collisionDir);
        Destroy(effect, 0.5f);
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Destroy(collision.gameObject);
        }
        ///
        Destroy(gameObject);
    }


}
