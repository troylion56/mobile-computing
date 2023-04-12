using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class razzoShoting : proiettili
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start(){
        rb.velocity = transform.up * speed;
        
    }

    void Update() {
        Distruggi();
    }

    void OnTriggerEnter2D(Collider2D collisione) {
        if (collisione.CompareTag("proiettili"))
        {
            impattoProiettili(collisione.GetComponent<proiettili>(),collisione);
        }
        if (collisione.CompareTag("ostacoli"))
        {
            Destroy(gameObject);
        }
        if (collisione.CompareTag("collectable"))
        {
            impattoCollezionabili(collisione.GetComponent<collect>(),collisione);
        }
    }

    private void impattoProiettili (proiettili proiettile,Collider2D collisione){
        if (proiettile is bulletScript)
        {
            Debug.Log("collisione ignorata razzo-proiettile");
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(),collisione);
        }
    }

    private void impattoCollezionabili (collect proiettile,Collider2D collisione){
        Debug.Log("collisione ignorata razzo-collezionabile");
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(),collisione);
    }
    void Distruggi() 
    {
        if(gameObject.transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
}
