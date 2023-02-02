using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aprireggggg : MonoBehaviour
{
    public Animator transizione; 
    
    public void apriregistrazione(){
        transizione.SetTrigger("aprireg");
    }
}
