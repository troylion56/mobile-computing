using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine.UI;

public class scriptAggiornaValoreVolume : MonoBehaviour
{
    //! script che modifica e tiene aggiornato il valore percentuale dello slider

    public Text valore;     //variabile di testo dove scrivo la percentuale
    public Slider sliderVolume;     //variabile slider

    void Start()
    {
        /*prendo il valore float dello slider e ne tagli la parte decimale*/
        /*moltiplico per 100 per semplificare la lettura*/
        double volume=Math.Truncate(sliderVolume.value*100);
        /*aggiorno la scritta nel testo*/
        valore.GetComponent<Text>().text=volume.ToString()+"%"; 
    }

    /*quando lo slider viene modificato aggiorno il valore scritto*/
    public void aggiorna(){
        /*prendo il valore float dello slider e ne tagli la parte decimale*/
        /*moltiplico per 100 per semplificare la lettura*/
        double volume=Math.Truncate(sliderVolume.value*100);
        /*aggiorno la scritta nel testo*/
        valore.GetComponent<Text>().text=volume.ToString()+"%"; 
    }
}
