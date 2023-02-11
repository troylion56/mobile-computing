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
    public GameObject benzina;
    private float shootTimer;
    public float shootRate;

    /* vita */
    public int health;
    public int danno;
    public GameObject barraHP;
    public Sprite health0, health1, health2, health3, health4;
    public SpriteRenderer immagine;
    Animator animator;
    public bool morto;

    public void Start() {
        arrivato = false;
        dx = true;
        sx = false;

        health = 4;
        danno = 1;

        shootRate = 0.6f;

        immagine.sprite = health4;

        animator = GetComponent<Animator>();
        morto = false;

    }

    public void Update() {
        
        if (!gameController.pausa){
                /* movimento verticale */
            if(transform.position.y > 2.5) {
                transform.position = new Vector2 (transform.position.x, transform.position.y - 4f*Time.deltaTime);
            }
            if(transform.position.y <= 2.5) {
                arrivato = true;
            }
            /* movimento orizzontale (solo quando sei in posizione) */
            if(arrivato){
                if(sx) {
                    transform.position = new Vector2 (transform.position.x + 0.03f, transform.position.y);
                }
                if(dx) {
                    transform.position = new Vector2 (transform.position.x - 0.03f, transform.position.y);
                }

                if(transform.position.x >= 1.83) {
                    dx = true;         // sei arrivato alla fine destra dello schermo
                    sx = false;
                }
                if(transform.position.x <= -1.83) {
                    sx = true;             // sei arrivato alla fine sinistra dello schermo
                    dx = false;
                }
                shootTimer += Time.deltaTime;
            }
        }
        if(arrivato && shootTimer >= shootRate) {
            float temp=transform.position.x*10;
            temp=Mathf.Round(temp);
            if (temp==0f||temp==9f||temp==-9f||temp==18f||temp==-18f){
                shootTimer=0;
                enemyShoot();
            }
        }
        Debug.Log("posizione: "+transform.position.x);

        if(morto) {
            StartCoroutine(destructionDelay());                 // sei morto, parte l'esplosione

        }
    }

    void enemyShoot() {
        Instantiate(enemyShotPreFab, puntoFuoco.position, puntoFuoco.rotation);
    }


    /* GESTIONE DELLE COLLISIONI */
    private void OnTriggerEnter2D(Collider2D collider2D) {
        if(collider2D.CompareTag("proiettili")){
            impatto(collider2D.GetComponent<proiettili>());
        }
        if(collider2D.CompareTag("ostacoli")){
            if (sx){
                sx=false;
                dx=true;
            }else{
                sx=true;
                dx=false;
            }
        }
    }

    private void impatto (proiettili proiettile){
        if (proiettile is razzoShoting) {
            Debug.Log("missile colpisce nemico");
            takeDamage(danno);
        }
        if (proiettile is bulletScript) {
            Debug.Log("player colpisce nemico");
            takeDamage(danno);
        }
    }

    private void collisioneProiettili (bulletScript bullet, Collider2D collisione) {
        if(bullet is bulletScript) {
            morto = true;
            StartCoroutine(destructionDelay());
            Debug.Log("Shot ha colpito il nemico che è stato distrutto");
            animator.SetTrigger("isDead");
        }
    }

    IEnumerator destructionDelay() {
        yield return new WaitForSeconds(0.5f);
        yield return null;
        morto = false;
        Debug.Log("coroutine morte nemico attivata");
        muori();
    }


    public void takeDamage(int danno) {
        health -= danno;            // danneggia di un tot
        
        if(health <= 0) {
            morto = true;
            Debug.Log("hai ucciso un nemico");
            animator.SetTrigger("isDead");
            
        }
        
        if(health == 0) {
            immagine.sprite = health0;
        }
        if(health == 1) {
            immagine.sprite = health1;
        }
        if(health == 2) {
            immagine.sprite = health2;
        }
        if(health == 3) {
            immagine.sprite = health3;
        }
        if(health == 4) {
            immagine.sprite = health4;
        }
    }
    
    /* per far spawnare e muovere la carica di benzina quando il nemico muore */
    public void muori() {
        Debug.Log("nemico distrutto");
        Instantiate(benzina, puntoFuoco.position, puntoFuoco.rotation);
        transform.position = new Vector2 (transform.position.x, transform.position.y - 4f*Time.deltaTime);          // muovi in basso
        if(transform.position.y < -6) {
            Destroy(gameObject);            // distruggi la tanica di benzina se sei fuori dallo schermo
        }
        Destroy(gameObject);                // alla fine distruggi il nemico
    }
}
