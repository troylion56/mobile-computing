 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apriLogin : MonoBehaviour
{
    public Animator transizione; 
    
    public void apri(){
        transizione.SetTrigger("apriLogin");
    }
}
