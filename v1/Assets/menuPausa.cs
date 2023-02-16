using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuPausa : MonoBehaviour
{
    public Button volume;
    public Animator aaa;

    // Update is called once per frame
    void Update()
    {
        if(vaiAVolume.isVolume) {
            aaa.SetBool("volume",true);
        }
        if(backPausePanel.backPan) {
            aaa.SetBool("volume",false);
        }
        if(backPausePanel.backPan) {
            aaa.SetTrigger("pannADx");
        }

    }
}
