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


    // Start is called before the first frame update
    void Start()
    {
        morto = false;
        // pos = transform.position;
        animator = GetComponent<Animator>();
        

    }
    
    void Update() {
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
        if (hitInfo.CompareTag("ostacoli"))
        {
            morto = true;
            collisioneOstacoli(hitInfo.GetComponent<ostacoli>());
        }

        if (hitInfo.CompareTag("proiettili"))
        {
            collisioneProiettili (hitInfo.GetComponent<proiettili>(),hitInfo);
        }

        if (hitInfo.CompareTag("nemico"))
        {
            morto = true;
            collisioneNemici (hitInfo.GetComponent<enemyScript>(),hitInfo);
        }

    }

    private void collisioneOstacoli (ostacoli ostacolo){
        if (ostacolo is enemyScript || ostacolo is asteroide)
        {
            morto = true;
            Debug.Log("Shot ha colpito il nemico ed è stato distrutto");
            animator.SetTrigger("hit");
        }

        
    }

    private void collisioneProiettili (proiettili proiettile, Collider2D collisione){
        if (proiettile is razzoShoting)
        {
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(),collisione);  
        }
    }

    private void collisioneNemici (enemyScript enemy, Collider2D collisione) {
        if(enemy is enemyScript) {
            morto = true;
            StartCoroutine(destructionDelay());
            Debug.Log("Shot ha colpito il nemico ed è stato distrutto");
            animator.SetTrigger("hit");
        }
    }

    /* coroutine per la gestione dell'animazione dell'esplosione */
    IEnumerator destructionDelay() {
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);            // l'esplosione è finita, muori
        yield return null;
        morto = false;
        Debug.Log("coroutine attivata");
    }


    void Distruggi()                // quando esce dallo schermo
    {
        if(gameObject.transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }

    

}
