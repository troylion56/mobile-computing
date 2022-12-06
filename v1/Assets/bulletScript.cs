using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : proiettili
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }
    
    void Update() {
        Distruggi();
    }

    void OnTriggerEnter2D(Collider2D hitInfo) 
    {
        enemyScript enemy = hitInfo.GetComponent<enemyScript>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);            
        }
        Destroy(gameObject);

    }

    void Distruggi() 
    {
        if(gameObject.transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
}
