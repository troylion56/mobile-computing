using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tornaSchermataPrincipale : MonoBehaviour
{
    public Button button;
    public Animator anim;

    public void clicca() {
        // se clicchi fai partire l'animazione che ti chiede se vuoi veramente uscire
        anim.SetTrigger("esci");
    }
}
