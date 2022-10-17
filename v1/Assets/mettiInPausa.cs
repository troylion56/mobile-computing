using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mettiInPausa : MonoBehaviour
{

    public Animator transizione;    
    public void giocoInPausa(){
        gameController.pausa=true;
        Time.timeScale=0f;
        transizione.SetTrigger("triggerApriPausa");
    }
}
