using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class livelloBenzinaPlayer : MonoBehaviour
{
    public Animator transizione; 
    public Slider benzina;

    // Update is called once per frame
    void Update()
    {
        if (benzina.value==0)
        {
            Destroy(gameObject);
            gameController.pausa=true;
            Time.timeScale=0f;
            Debug.Log("sesso");
            transizione.SetTrigger("fadeInBackGround");
        }
    }
}
