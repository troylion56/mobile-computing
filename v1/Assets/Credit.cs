using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit : MonoBehaviour
{
    public Animator transizione; 
    public soundManager SManager;
    
    public void apri(){
        SManager.playPausa();
        transizione.SetTrigger("apriCredit");
    }
}
