using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class asteroide : ostacoli
{
    // Update is called once per frame
    void Update()
    {
        if(!gameController.pausa){
            transform.position = new Vector2 (transform.position.x, transform.position.y-2.5f*Time.deltaTime);
        }

        if (transform.position.y<=-5.6f)
        {
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
            Debug.Log("missile colpisce asteroide");
            Destroy(gameObject);
        }
        if (proiettile is bulletScript)
        {
            Debug.Log("asteroide colpisce proiettile");
        }
    }


}
