using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mettiPlay : MonoBehaviour
{
    public Animator transizione;
    public Button pulsanteRazzo;
    public static bool isPlay;

    public void Update() {
        if(gameController.pausa) {
            isPlay = false;
        }
        if(!gameController.pausa) {
            isPlay = true;
        }
    }
        public void play(){
        gameController.pausa=false;
        Time.timeScale=1f;
        Debug.Log("stato: "+razzo.stato);
        if (razzo.stato)
        {
            pulsanteRazzo.interactable=true;
        }
        transizione.SetTrigger("triggerChiudiPausa");
    }
}
