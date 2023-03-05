using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tornaAGioco : MonoBehaviour
{
    public Animator anim;
    
    public void clicca() {
        // fai partire l'animazione al contrario
        anim.SetTrigger("torna");

    }
}
