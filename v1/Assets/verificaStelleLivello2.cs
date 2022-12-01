using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine.UI;

public class verificaStelleLivello2 : MonoBehaviour
{
    public SpriteRenderer ss11; //ss prima stellina del primo livello
    public SpriteRenderer ss12; //ss seconda stellina del primo livello
    public SpriteRenderer ss13; //ss terza stellina del primo livello

    public Sprite stellaAttiva;

    void Start()
    {
        if (!PlayerPrefs.HasKey("superStella2:1")){
                PlayerPrefs.SetInt("superStella2:1",0);
        }
        else{
                aggiornaSpirte (PlayerPrefs.GetInt("superStella2:1"),ss11);
        }
        if (!PlayerPrefs.HasKey("superStella2:2")){
                PlayerPrefs.SetInt("superStella2:2",0);
        }
        else{
                aggiornaSpirte (PlayerPrefs.GetInt("superStella2:2"),ss12);
        }
        if (!PlayerPrefs.HasKey("superStella2:3")){
                PlayerPrefs.SetInt("superStella2:3",0);
        }
        else{
                aggiornaSpirte (PlayerPrefs.GetInt("superStella2:3"),ss13);
        }
        
    }

    void aggiornaSpirte(int verifica,SpriteRenderer stella){
        if(verifica==1){
            stella.sprite=stellaAttiva;
        }
    }   
}
