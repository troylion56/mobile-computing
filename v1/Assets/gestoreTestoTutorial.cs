using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gestoreTestoTutorial : MonoBehaviour
{
    public TextMeshProUGUI tutorial;
    public GameObject continua;
    public static bool dialogo=true;
    private Vector2 posIniziale;
    private Vector2 posAttuale;
    private Vector2 posFinale;
    private bool stopTouch=false;
    public Transform posizione;
    public float swipeTime;
    public float tapTime;
    public Animator spostamento;  
    string prova= "testo di prova per testare la comparsa singola delle lettere";
    public Animator transizioniTutorial;
    
    [TextArea(3,10)]
    public string [] dialoghi=new string [10];
    
    int contatoreDialoghi=0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            scrivi ();
        }


        if (Input.touchCount>0&&Input.GetTouch(0).phase==TouchPhase.Began)
        {
               posIniziale=Input.GetTouch(0).position;
        }
        
         if (Input.touchCount>0&&Input.GetTouch(0).phase==TouchPhase.Ended)
        {
            stopTouch=false;
            posFinale=Input.GetTouch(0).position;

            Vector2 distanza=posFinale-posIniziale;

            if (Mathf.Abs(distanza.x)<tapTime && Mathf.Abs(distanza.y)<tapTime)
            {
                scrivi ();
                Debug.Log("tap");
            }
        }
    }

    public void scrivi (){
        if (contatoreDialoghi==4)
        {
            transizioniTutorial.SetTrigger("uscitaTutorial");
        }
        StopAllCoroutines();
        StartCoroutine(scrittura(dialoghi[contatoreDialoghi]));
        contatoreDialoghi++;
    }

    IEnumerator scrittura (string dialogo){
        continua.SetActive(false);
        tutorial.text="";
        foreach (char lettera in dialogo.ToCharArray()){
            tutorial.text += lettera;
            yield return new WaitForSeconds(0.05f);
        }
        continua.SetActive(true);
    }
}
