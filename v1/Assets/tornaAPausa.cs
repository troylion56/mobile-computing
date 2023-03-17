using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tornaAPausa : MonoBehaviour
{
    public Animator pausa;
    public Animator volume;

    public void onClick (){
        pausa.SetTrigger("chiudiVolumiP");
        volume.SetTrigger("chiudiVolumeV");
    }
}
