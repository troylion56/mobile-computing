using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : ostacoli
{
    public Transform posizione;
    private Vector2 posCorr;
    private bool arrivato;
    private bool dx;
    private bool sx;

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
                transform.position = new Vector2 (transform.position.x + 1.5f*Time.deltaTime, transform.position.y);
            }
            if(dx) {
                transform.position = new Vector2 (transform.position.x - 1.5f*Time.deltaTime, transform.position.y);
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
    



    
    private void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag("proiettili")){
            colpisci(col.GetComponent<proiettili>());
        }
    }

    private void colpisci(proiettili proiettile) {
        if(proiettile is razzoShoting) {
            Destroy(gameObject);
            Debug.Log("Nemico distrutto da razzo");
        }
        if(proiettile is bulletScript) {
            Debug.Log("Nemico colpito da proiettile");
            TakeDamage();
        }
    }


    public void TakeDamage()
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