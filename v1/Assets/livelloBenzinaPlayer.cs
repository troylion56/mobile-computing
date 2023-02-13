using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class livelloBenzinaPlayer : MonoBehaviour
{
    public Animator transizione; 
    public Slider benzina;
    public Transform posizione;

    // Update is called once per frame
    void Update()
    {
        if (benzina.value==0)
        {
            gameController.pausa=true;
            Time.timeScale=0f;
            Debug.Log("sesso");
            cadi();
            StartCoroutine(wait());
            transizione.SetTrigger("triggerMorte");
        }
    }

    public void cadi() {
        transform.position = new Vector2(transform.position.x, transform.position.y - 0.05f);
        if(transform.position.y < -7) {
            Destroy(gameObject);
        }
    }

    IEnumerator wait() {
        yield return new WaitForSeconds(1f);
        Debug.Log("aspettaaaa");
    }
}
