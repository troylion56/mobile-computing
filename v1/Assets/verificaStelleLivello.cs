using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine.UI;

public class verificaStelleLivello : MonoBehaviour
{
    public SpriteRenderer ss11; //ss prima stellina del primo livello
    public SpriteRenderer ss12; //ss seconda stellina del primo livello
    public SpriteRenderer ss13; //ss terza stellina del primo livello

    public Sprite stellaAttiva;
    void Start()
    {
        if (!PlayerPrefs.HasKey("superStella1:1")){
                PlayerPrefs.SetInt("superStella1:1",0);
        }else{
                aggiornaSpirte (PlayerPrefs.GetInt("superStella1:1"),ss11);
        }

         if (!PlayerPrefs.HasKey("superStella1:2")){
                PlayerPrefs.SetInt("superStella1:2",0);
        }else{
                aggiornaSpirte (PlayerPrefs.GetInt("superStella1:2"),ss12);
        }

         if (!PlayerPrefs.HasKey("superStella1:3")){
                PlayerPrefs.SetInt("superStella1:3",0);
        }else{
                aggiornaSpirte (PlayerPrefs.GetInt("superStella1:3"),ss13);
        }
    }

    void aggiornaSpirte(int verifica,SpriteRenderer stella){
        if(verifica==1){
            stella.sprite=stellaAttiva;
        }
    }
} 

