using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mettiPlay : MonoBehaviour
{
    public soundManager SManager;
    public Animator transizione;
    public Button pulsanteRazzo;

   
        public void play(){
        SManager.playPausa();
        gameController.pausa=false;
        Time.timeScale=1f;
        Debug.Log("stato: "+razzo.stato);
        if (razzo.stato)
        {
            pulsanteRazzo.interactable=true;
        }
        transizione.SetTrigger("chiudiPausa");
    }
}
