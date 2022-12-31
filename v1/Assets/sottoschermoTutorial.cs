using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sottoschermoTutorial : MonoBehaviour
{
     public gestoreTestoTutorial tutorial;
    private void OnTriggerEnter2D(Collider2D collider2D) {
        Debug.Log("qpirguqhbgfoaiufgbqoeufrgbhqoirugbiuy");
        if (gestoreTestoTutorial.contatoreDialoghi==8){
            gestoreTestoTutorial.contatoreDialoghi=12;
            Debug.Log("asteroide tutorial sottoschermo");
            tutorial.scrivi();       
        }
    }
}
