using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vaiAVolume : MonoBehaviour
{
    public soundManager SManager;
    public Animator pausa;
    public Animator volume;

    public void onClick (){
        SManager.playPausa();
        pausa.SetTrigger("apriVolumiP");
        volume.SetTrigger("apriVolumeV");
    }
}
