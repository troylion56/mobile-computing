using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pulsanteEsci : MonoBehaviour
{
    public Button button;
    public Animator anim;

    public void clicca() {
        // se clicchi fai partire l'animazione che tin chiede se vuoi veramente uscire
        anim.SetTrigger("esci");
        Debug.Log("hai cliccato il pulsante esci!");
    }
}
