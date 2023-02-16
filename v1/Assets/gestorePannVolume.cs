using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gestorePannVolume : MonoBehaviour
{   
     public Animator scorri;

    public void scorriPann() {
        if(vaiAVolume.isVolume) {           // cioè se hai cliccato per farlo apparire
            scorri.SetTrigger("volu");
        }
    }
    
}
