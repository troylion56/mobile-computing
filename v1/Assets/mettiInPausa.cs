using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mettiInPausa : MonoBehaviour
{
    public soundManager SManager;
    public Animator transizione; 
    public Button pulsanteRazzo;

    public void giocoInPausa(){
        SManager.playPausa();
        gameController.pausa=true;
        Time.timeScale=0f;
        pulsanteRazzo.interactable=false;
        transizione.SetTrigger("apriPausa");
    }
}
