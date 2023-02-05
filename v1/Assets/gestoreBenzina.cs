using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gestoreBenzina : MonoBehaviour
{
    public Slider benzina;
    void Start()
    {
        benzina.value=100;
    }

    public void carica (int ricarica){
        benzina.value=benzina.value+ricarica;
    }



    private void Update() {

        if(Input.GetKeyDown(KeyCode.Q)) {
            benzina.value=0;
        }

        if (!gameController.pausa)
        {
            benzina.value=benzina.value-0.1f;
        }
    }
}
