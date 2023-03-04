using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class backPausePanel : MonoBehaviour
{
    public Animator back;
    public Button indietro;
    public static bool backPan;

    public void Start() {

    }

    public void Update () {
        if(menuPausa.isPausa || !gameController.pausa) {
            backPan = false;
        }
    }

    public void clicca() {
        back.SetTrigger("voluBack");
        backPan = true;
        
    }

}
