using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : ostacoli
{
    public int health = 100;

    public void Update() {
        if(gameObject.transform.position.y<8)
        {
            Destroy(gameObject);
        }
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