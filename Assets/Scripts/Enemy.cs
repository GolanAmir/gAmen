using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int DamageTaken = 1;
    private int life;
    public int HP;
    public Transform Hero;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;



    // Start is called before the first frame update
    void Start()
    {

        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Hero.position - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
   
    public void OnCollisionEnter2D(Collision2D other)
    {
        //If the object that triggered this collision is tagged "bullet"
        if (other.gameObject.tag.Equals("Bullet"))
        {
            
            HP -= DamageTaken;
            if (HP <= 0) {
                Destroy(gameObject);
            }
        }
    }
}