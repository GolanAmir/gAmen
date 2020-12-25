using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
   
    void OnCollisionEnter2D(Collision2D collision)
    {
        Quaternion collisionDir = transform.rotation;
        /*Vector3 vv = collisionDir.eulerAngles;
        vv.y = Mathf.Round(vv.y / 45.0f) * 45.0f;
        collisionDir.eulerAngles = vv;
        */
        GameObject effect = Instantiate(hitEffect, transform.position, collisionDir);
        Destroy(effect, 0.05f);
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }


}
