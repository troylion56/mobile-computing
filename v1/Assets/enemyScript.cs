using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : ostacoli
{
    public Transform posizione;
    public Vector2 pos;
    public Vector2 posIniziale;
    public Vector2 posCorr;         // per la posizione corrente
    public int health = 100;
    

    public void Start() {
    }

    public void Update() {

        if(transform.position.y < 8) {
            Destroy(gameObject);
        }
        
        
       
       /* posCorr = posizione.transform.position;
        
        //if(posCorr.y < 2.5 && ! arrivato) {
            posCorr.y -= 4f;
            arrivato = true;
        }
        
        // quando è in posizione deve andare sx dx
        if(posCorr.y <= 2.5 && posCorr.x < 1.73)
        {
            posCorr.x += 4f;            // muovi a dx
        }

        if(posCorr.y <= 2.5 && posCorr.x > -1.73)
        {
            posCorr.x -= 4f;           // muovi a sx
        }
     */   
    }
    
    public void TakeDamage(int Damage)
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