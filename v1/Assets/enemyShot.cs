using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShot : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -6) {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag("Player")) {
            Destroy(gameObject);
            Debug.Log("Proiettile ha colpito il player ed è stato distrutto");
        }
    }
}
