using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class asteroideTutorial : ostacoli
{
    public Animator aster;
    public GameObject oide;
    public soundManager SManager;
    void Update()
    {
        if(!gameController.pausa){
            transform.position = new Vector2 (transform.position.x, transform.position.y-2.5f*Time.deltaTime);

        }

        if (transform.position.y<=-7f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider2D) {
        if(collider2D.CompareTag("proiettili")){
            impatto(collider2D.GetComponent<proiettili>());
        }else{
            aster.SetTrigger("distruzione");
            oide.GetComponent<Collider2D>().enabled=false;
        }
    }

    private void impatto (proiettili proiettile){
        if (proiettile is razzoShoting)
        {
            Debug.Log("missile colpisce asteroide");
            aster.SetTrigger("distruzione");
            oide.GetComponent<Collider2D>().enabled=false;
            SManager.playDistruzioneAsteroidi();
        }
        if (proiettile is bulletScript)
        {
            Debug.Log("asteroide colpisce proiettile");
        }
    }
}
