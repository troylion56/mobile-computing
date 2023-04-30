using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class asteroide : ostacoli
{
    public Animator aster;
    public GameObject oide;
    private bool distrutto;
    public soundManager SManager;
    
    private void Start() {
        distrutto=false;
    }

    void Update()
    {
        if(!gameController.pausa){
            transform.position = new Vector2 (transform.position.x, transform.position.y-2.5f*Time.deltaTime);
        }

        if (transform.position.y<=-5.6f){
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider2D) {
        if(collider2D.CompareTag("proiettili")){
            impatto(collider2D.GetComponent<proiettili>());
        }
    }

    private void impatto (proiettili proiettile){
        if (proiettile is razzoShoting)
        {
            SManager.playDistruzioneAsteroidi();
            Debug.Log("missile colpisce asteroide");
            aster.SetTrigger("distruzione");
            oide.GetComponent<Collider2D>().enabled=false;
            Debug.Log("bbbbbbbbbbbbbbbb");
            distrutto=true;
        }
        if (proiettile is bulletScript)
        {
            Debug.Log("asteroide colpisce proiettile");
        }
    }
}
