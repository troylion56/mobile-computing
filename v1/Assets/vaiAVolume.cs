using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vaiAVolume : MonoBehaviour
{
    public Animator pausa;
    public Animator volume;

    public void onClick (){
        pausa.SetTrigger("apriVolumiP");
        volume.SetTrigger("apriVolumeV");
    }
}
