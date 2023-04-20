using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine.UI;

public class ScriptGestisciVolume : MonoBehaviour
{
    //! script che tramite il valore dello slider gestisce il volume

    public static Slider sliderVolume;     //variabile di tipo slider

    void Start(){
        /*se esiste in memoria un precedente salvataggio del volume*/
        if (!PlayerPrefs.HasKey("volumeGenerale")){
            /*se non esiste un salvataggio del volume lo imposto di default a 1 (100%)*/
            PlayerPrefs.SetFloat("volumeGenerale",1);
            /*dopo aver assegnato il valore di default lo assegno come valore dello slider*/
            carica();
        }else{
            /*se esiste un precedente salvataggio lo assegno come valore dello slider*/
            carica();
        }
    }

    /*metodo che cambia il volume in base al valore attuale dello slider*/
    /*questo metodo viene chiamato ogi volta che il valore dellos lider viene modificato manualmente*/
    public void cambiaVolume(){
        /*assegno il valored ello slider al volume generale*/
        AudioListener.volume=sliderVolume.value;
        /*salvo in memoria la modifica*/
        salva();
    }

    private void carica (){
        /*carico da la memoria l'attuale valore dello slider*/
        sliderVolume.value=PlayerPrefs.GetFloat("volumeGenerale");
    }

    private void salva (){
        /*salvo in memoria l'attuale valore dello slider*/
        PlayerPrefs.SetFloat("volumeGenerale",sliderVolume.value);
    }

}
