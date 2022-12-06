using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bottoneShoot : MonoBehaviour
{
    public Sprite caricamento0, caricamento1, caricamento2, caricamento3;
    public int colpiDisponibili;
    public SpriteRenderer shootingButton;
    public Button pulsante;
    public Image prova;

    void Start() {
        colpiDisponibili = 3;
    }


    public void cambiaSprite() {
        if(colpiDisponibili == 1) {
            prova.sprite = caricamento1;
        }
        else if(colpiDisponibili == 2) {
            prova.sprite = caricamento2;
        }
        else if(colpiDisponibili == 3) {
            prova.sprite = caricamento3;
        }
        else if(colpiDisponibili == 0) {
            prova.sprite = caricamento0;

        }

    }



}
