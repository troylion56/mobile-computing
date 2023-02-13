using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gestoreBenzina : MonoBehaviour
{
    public Slider benzina;
    public static bool finita;
    void Start()
    {
        finita = false;
        benzina.value=100;
    }

    public void carica (int ricarica){
        benzina.value=benzina.value+ricarica;
    }



    private void Update() {

        if(Input.GetKeyDown(KeyCode.Q)) {
            benzina.value=0;
            finita = true;
        }


        if(Input.GetKeyDown(KeyCode.G)) {
            benzina.value=100;
        }

        if (!gameController.pausa)
        {
            benzina.value=benzina.value-0.1f;
        }
    }
}
