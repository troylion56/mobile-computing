using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyScript : ostacoli
{
    /* per farlo muovere */
    public Transform posizione;
    private Vector2 posCorr;
    private bool arrivato;
    private bool dx;
    private bool sx;

    /* per farlo sparare */
    public Transform puntoFuoco;
    public GameObject enemyShotPreFab;
    private float shootRate;
    private float shooting;

    /* barra hp */
    public static int health;
    public int danno;
    public Sprite vita0, vita1, vita2, vita3;
    public GameObject barraHP;

    

    public void Start() {
        arrivato = false;
        dx = true;
        sx = false;

        shootRate = 5f;

        health = 4;
        danno = 1;

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

            shooting = shootRate * Time.deltaTime;
        }

        if(arrivato && shooting>=0.1f) {
            enemyShoot();                   // inizi a sparare quando sei in posizione
        }
        
        
    }

    void enemyShoot() {
        // Instantiate(enemyShotPreFab, puntoFuoco.position, puntoFuoco.rotation);
    }


    /* GESTIONE DELLE COLLISIONI */
    private void OnTriggerEnter2D(Collider2D collider2D) {
        if(collider2D.CompareTag("proiettili")){
            impatto(collider2D.GetComponent<proiettili>());
        }
    }

    private void impatto (proiettili proiettile){
        if (proiettile is razzoShoting) {
            Debug.Log("missile colpisce nemico");
            Destroy(gameObject);
        }
        if (proiettile is bulletScript) {
            Debug.Log("player colpisce nemico");
            takeDamage(danno);
        }
    }



    public void takeDamage(int danno) {
        health -= danno;            // danneggia di un tot
        if(health <= 0) {
            Destroy(gameObject);            // muore
            Debug.Log("hai ucciso un nemico");
        }
        
    }

}