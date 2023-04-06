using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : proiettili
{
    public float speed = 20f;
    Vector3 pos;
    public int damage = 40;
    public Rigidbody2D rb;
    Animator animator;
    public bool morto;
    private bool colpitoAsteroide;


    // Start is called before the first frame update
    void Start()
    {
        morto = false;
        // pos = transform.position;
        animator = GetComponent<Animator>();

        colpitoAsteroide=false;
    }
    
    void Update() {

        /*effetto necessario per vedere l'impatto del proiettile sui meteoriti*/
        if (colpitoAsteroide){
            transform.position = new Vector2 (transform.position.x, transform.position.y-2.5f*Time.deltaTime);
        }

        Distruggi();            // se esce dallo schermo
        
        if(!morto) {
            transform.position = new Vector2 (transform.position.x, transform.position.y+15f*Time.deltaTime);
            pos += new Vector3(0,2,0);                    // movimento in basso
        }
        if(morto) {
            StartCoroutine(destructionDelay());                 // sei morto, parte l'esplosione
        }

    }

    void OnTriggerEnter2D(Collider2D hitInfo) 
    {
        if (hitInfo.CompareTag("ostacoli")) {
            morto = true;
            collisioneOstacoli(hitInfo.GetComponent<ostacoli>());
        }

        if (hitInfo.CompareTag("proiettili")){
            collisioneProiettili (hitInfo.GetComponent<proiettili>(),hitInfo);
        }

        if (hitInfo.CompareTag("nemico")){
            morto = true;
            collisioneNemici (hitInfo.GetComponent<enemyScript>(),hitInfo);
        }

    }

    /*caso di collisone con un asteroide*/
    private void collisioneOstacoli (ostacoli ostacolo){
        if (ostacolo is asteroide){
            morto = true;
            colpitoAsteroide=true;
            StartCoroutine(destructionDelay());
            Debug.Log("Shot ha colpito un asteroide ed è stato distrutto");
        }
    }

    /*caso di collisione con un razzo sparato dal player*/
    private void collisioneProiettili (proiettili proiettile, Collider2D collisione){
       /// if (proiettile is razzoShoting){
        //    Physics2D.IgnoreCollision(GetComponent<Collider2D>(),collisione);  
        //}

        if (proiettile is enemyShot){
        }
            morto = true;
            colpitoAsteroide=true;
            StartCoroutine(destructionDelay());
            Debug.Log("Shot ha colpito un proiettile nemico ed è stato distrutto");
    }

    /*caso di collisione con un nemico*/
    private void collisioneNemici (enemyScript enemy, Collider2D collisione) {
        if(enemy is enemyScript) {
            morto = true;
            StartCoroutine(destructionDelay());
            Debug.Log("Shot ha colpito il nemico ed è stato distrutto");
        }
    }

    /* coroutine per la gestione dell'animazione dell'esplosione */
    IEnumerator destructionDelay() {
        animator.SetTrigger("hit");
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);            // l'esplosione è finita, muori
        yield return null;
        morto = false;
    }


    void Distruggi()                // quando esce dallo schermo
    {
        if(gameObject.transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
}
