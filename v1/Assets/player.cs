using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public gestoreVita vita;
    public int health = 100;

    void Update()
    {

        //!-----------------debug-------------------
        /*
            if(gameController.fineLiv) {
                    Debug.Log("vediamoSechiama");
                    transform.position = new Vector2 (transform.position.x, transform.position.y+2.5f*Time.deltaTime);
                }
            */

        if(health <= 0) {
            Die();
        }
        

    }


    /* COLLISIONI */

    private void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag("proiettili")){
            colpisci(col.GetComponent<proiettili>());
        }
    }

    private void colpisci(proiettili proiettile) {
        if(proiettile is enemyShot) {
            Debug.Log("Player colpito");
            takeDamage();
        }
    }


    public void takeDamage() {
        health -= 10;            // tolgo 20 di vita al player
    }

    public void Die() {
        Destroy(gameObject);
    }

}