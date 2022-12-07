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
        if (hitInfo.CompareTag("ostacoli"))
        {
            collisioneOstacoli(hitInfo.GetComponent<ostacoli>());
        }

        if (hitInfo.CompareTag("proiettili"))
        {
            collisioneProiettili (hitInfo.GetComponent<proiettili>(),hitInfo);
        }
    }

    private void collisioneOstacoli (ostacoli ostacolo){
        if (ostacolo is enemyScript)
        {
        enemyScript enemy = ostacolo.GetComponent<enemyScript>();
          if(enemy != null){
            enemy.TakeDamage(damage);            
            }
            Destroy(gameObject);
        }

        if (ostacolo is asteroide)
        {
            Destroy(gameObject);
        }
    }

    private void collisioneProiettili (proiettili proiettile,Collider2D collisione){
        if (proiettile is razzoShoting)
        {
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(),collisione);  
        }
    }
    void Distruggi() 
    {
        if(gameObject.transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
}
