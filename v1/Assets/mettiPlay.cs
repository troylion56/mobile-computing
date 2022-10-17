using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mettiPlay : MonoBehaviour
{
    public Animator transizione;
        public void play(){
        gameController.pausa=false;
        Time.timeScale=1f;
        transizione.SetTrigger("triggerChiudiPausa");
    }
}
