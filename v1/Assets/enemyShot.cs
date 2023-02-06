using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShot : MonoBehaviour
{
    Vector3 posizione;
    private bool morto = false;
    float rotateSpeed = 400;
    Animator animator;
    public float transitionTime = 3f;

    void Start() {
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if(!morto) {
            transform.position = new Vector2 (transform.position.x, transform.position.y-4f*Time.deltaTime);
            posizione += new Vector3(0,2,0);                    // movimento in basso
        }

        float angle = rotateSpeed * Time.deltaTime;
        transform.rotation *= Quaternion.AngleAxis(angle, Vector3.forward);         // effetto rotazione proiettile
        
        if(transform.position.y < -6) {
            Destroy(gameObject);        // distruggi quando esci dallo schermo
        }

        if(morto) {
            StartCoroutine(destructionDelay());                 // sei morto, parte l'esplosione
        }
    }

    
    private void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag("Player")) {
            morto = true;
            Debug.Log("Proiettile ha colpito il player ed è stato distrutto");
            animator.SetTrigger("morto");

        }
    }


    IEnumerator destructionDelay() {            // aspetta a distruggersi
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);            // l'esplosione è finita, muori
        yield return null;
        morto = false;
    }



}
