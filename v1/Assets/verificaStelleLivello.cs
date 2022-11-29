using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine.UI;

public class verificaStelleLivello : MonoBehaviour
{
    public GameObject ss11; //ss prima stellina del primo livello
    public GameObject ss12; //ss seconda stellina del primo livello
    public GameObject ss13; //ss terza stellina del primo livello

     public Sprite stellaAttiva;
    void Start()
    {
        if (!PlayerPrefs.HasKey("superStella1:1")){
            /*se non esiste un salvataggio del volume lo imposto di default a 1 (100%)*/
            PlayerPrefs.SetBool("superStella1:1",false);
        }else{
            /*se esiste un precedente salvataggio lo assegno come valore dello slider*/
            carica();
            aggiornaSpirte (PlayerPrefs.GetBool("superStella1:1"),ss11);
        }
    }

    void aggiornaSpirte(bool verifica,GameObject stella){
        if(verifica){
            
        }
    }
}

