using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pulsanteEsci : MonoBehaviour
{
    public Animator anim;
    public GameObject menu;

    public void clicca() {
        // se clicchi fai partire l'animazione che tin chiede se vuoi veramente uscire
        menu.SetActive(true);
        anim.SetTrigger("apri");
        Debug.Log("hai cliccato il pulsante esci!");
    }
}
