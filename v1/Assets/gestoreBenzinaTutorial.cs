using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gestoreBenzinaTutorial : MonoBehaviour
{
    public Slider benzina;
    void Start()
    {
        benzina.value=50;
    }

    public void carica (int ricarica){
        benzina.value=benzina.value+ricarica;
    }



    private void Update() {

        if(Input.GetKeyDown(KeyCode.Q)) {
            benzina.value=0;
        }

        if (!gameController.pausa&&!gestoreTestoTutorial.dialogo&&gestoreTestoTutorial.contatoreDialoghi<20)
        {
            benzina.value=benzina.value-0.1f;
        }
    }
}
