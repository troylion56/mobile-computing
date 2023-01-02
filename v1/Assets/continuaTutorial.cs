using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class continuaTutorial : MonoBehaviour
{
    private int contatore;
    public TextMeshProUGUI testo;
    void Start()
    {
        contatore=0;
        StartCoroutine(scrivi());
    }

    public void attesa(){
        contatore=0;
        testo.text="Tocca per continuare";
        StartCoroutine(scrivi());   
    }
    

    IEnumerator scrivi (){
        while (true)
        {
            if (contatore<3)
            {
                testo.text +=".";
                contatore++;
            }else{
                contatore=0;
                testo.text="Tocca per continuare";
            }
            yield return new WaitForSeconds(1);
        }
    }
}
