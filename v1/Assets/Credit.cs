using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit : MonoBehaviour
{
    public Animator transizione; 
    
    public void apri(){
        transizione.SetTrigger("apriCredit");
    }
}
