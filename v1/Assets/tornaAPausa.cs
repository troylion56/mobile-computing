using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tornaAPausa : MonoBehaviour
{
    public Animator pausa;
    public Animator volume;
    public soundManager SManager;

    public void onClick (){
        SManager.playPausa();
        pausa.SetTrigger("chiudiVolumiP");
        volume.SetTrigger("chiudiVolumeV");
    }
}
