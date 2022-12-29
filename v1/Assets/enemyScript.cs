using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : ostacoli
{
    public Transform posizione;
    private Vector2 posCorr;
    public bool arrivato;
    public bool dx;
    public bool sx;

    public int health = 100;
    

    public void Start() {
        arrivato = false;
        dx = true;
        sx = false;
    }

    public void Update() {
        
        /* movimento verticale */
        if(transform.position.y > 2.5) {
            transform.position = new Vector2 (transform.position.x, transform.position.y - 4f*Time.deltaTime);
        }
        if(transform.position.y <= 2.5) {
            arrivato = true;
        }
        
        /* movimento orizzontale (solo quando sei in posizione) */
        if(arrivato)
        {
            if(sx) {
                transform.position = new Vector2 (transform.position.x + 2f*Time.deltaTime, transform.position.y);
            }
            if(dx) {
                transform.position = new Vector2 (transform.position.x - 2f*Time.deltaTime, transform.position.y);
            }

            if(transform.position.x >= 1.83) {
                dx = true;         // sei arrivato alla fine destra dello schermo
                sx = false;
            }
            if(transform.position.x <= -1.83) {
                sx = true;             // sei arrivato alla fine sinistra dello schermo
                dx = false;
            }

        }

     
    }
    
    public void TakeDamage(int Damage)
    {
        health -= 40;
        if(health<0)
        {
            Die();
        }
    }

    void Die()
    {
        if(health<0)
        {
            Destroy(gameObject);
            Debug.Log("Nemico distrutto");
        }
    
    }

}