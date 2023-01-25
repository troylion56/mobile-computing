using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShot : MonoBehaviour
{
    Vector3 posizione;
    float rotateSpeed = 90;
    Animator animator;
    public Sprite img1, img2;

    void Start() {
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2 (transform.position.x, transform.position.y-4f*Time.deltaTime);
        posizione += new Vector3(0,2,0);        

        if(transform.position.y < -6) {
            Destroy(gameObject);
        }

        float angle = rotateSpeed * Time.deltaTime;
        transform.rotation *= Quaternion.AngleAxis(angle, Vector3.forward);


    }

    

    private void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag("Player")) {
            animator.SetTrigger("morto");       // fai scattare la transizione
            // Destroy(gameObject);
            Debug.Log("Proiettile ha colpito il player ed è stato distrutto");
        }
    }
}
