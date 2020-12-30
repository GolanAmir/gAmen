using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public int damage = 10;
    //public inaal abuk madafaka saamak unity nu kvarrrr

    void OnTriggerEnter2D(Collider2D collider)
    {
        Enemy enemy = collider.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Quaternion collisionDir = transform.rotation;
        GameObject effect = Instantiate(hitEffect, transform.position, collisionDir);
        Destroy(effect, 0.5f);
        Destroy(gameObject);
    }

    public int getDamage()
    {
        return damage;
    }

    public void setDamage(int newDamage)
    {
        damage = newDamage;
    }

}
