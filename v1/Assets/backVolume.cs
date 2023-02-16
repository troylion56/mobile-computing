using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backVolume : MonoBehaviour
{
    public Animator tornaPausa;
    // Start is called before the first frame update
    void Start()
    {
        // backVolume.Interactable = true;
        
    }

    public void tornaPannPausa() {
        vaiAVolume.isVolume = false;
    }
}
