using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mettiInPausa : MonoBehaviour
{

    public Animator transizione; 
    public Button pulsanteRazzo;
    [SerializeField] private AudioSource pausaSound;

    public void giocoInPausa(){
//        pausaSound.Play();
        gameController.pausa=true;
        Time.timeScale=0f;
        pulsanteRazzo.interactable=false;
        transizione.SetTrigger("triggerApriPausa");
    }
}
