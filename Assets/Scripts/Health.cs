using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public float stdDmg = 10f;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
  
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.tag.Equals("Bullet"))
        {
            TakeDamage(stdDmg);
        }
       
    }

    private void TakeDamage(float stdDmg)
    {
        currentHealth -= (int)stdDmg;
        healthBar.SetHealth(currentHealth);
    }

}
