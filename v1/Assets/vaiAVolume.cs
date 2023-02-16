using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vaiAVolume : MonoBehaviour
{
    public Button vaiVolume;
    public Animator animaz;             // l'animazione del pannello del volume
    public static bool isVolume;

    /* devi far partire l'animazione del pannello del volume quando premi il bottone che va lì */
    // Update is called once per frame
    
    public void Start() {
        vaiVolume.interactable = true;
        
    }

    public void panVolume() {
        // setta il trigger che fa partire il menu del volume
        animaz.SetBool("volu",true);           // fai partire la transizione
        isVolume = true;
    }

    public void torna() {
        if(isVolume) {
            animaz.SetTrigger("indietro");
        }
    }




}
