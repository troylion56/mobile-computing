using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gestoreTestoTutorial : MonoBehaviour
{
    public TextMeshProUGUI tutorial;
    
    string prova= "testo di prova per testare la comparsa singola delle lettere";
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            tutorial.fontSize=30;
            //StopAllCoroutines();
            StartCoroutine(scrittura(prova));
        }
    }

    IEnumerator scrittura (string dialogo){
        tutorial.text="";
        foreach (char lettera in prova.ToCharArray()){
            tutorial.text += lettera;
            yield return new WaitForSeconds(0.05f);
        }
    }
}
