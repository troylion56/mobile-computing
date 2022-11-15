using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class razzoShoting : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start(){
        rb.velocity = transform.up * speed;
        
    }
    void OnTriggerEnter2D(Collider2D hitInfo) 
    {
        /*enemyScript enemy = hitInfo.GetComponent<enemyScript>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);            
        }*/
        Debug.Log(hitInfo.name);
        Destroy(gameObject);

    }


    
}