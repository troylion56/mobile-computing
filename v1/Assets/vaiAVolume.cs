using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vaiAVolume : MonoBehaviour
{
    public Button vaiVolume;
    public Animator animaz;             // l'animazione del pannello del volume

    /* devi far partire l'animazione del pannello del volume quando premi il bottone che va lì */
    // Update is called once per frame
    public void Start() {
        animaz = GetComponent<Animation()>;
    }
    public vaiAVolume() {
        // setta il trigger che fa partire il menu del volume
        animaz.SetTrigger("vol");
    }


}
