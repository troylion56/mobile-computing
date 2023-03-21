using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chiudiEsci : MonoBehaviour
{
    public Animator anim;
    public GameObject menu;
    public void onClick (){
        StartCoroutine(chiudi());  
    }

    IEnumerator chiudi(){
        anim.SetTrigger("chiudi");
        yield return new WaitForSeconds (0.3f);
        menu.SetActive(false);
    }
}
