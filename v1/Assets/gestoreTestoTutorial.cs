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
    
    public static int contatoreDialoghi=0;

    private void Start() {
        contatoreDialoghi=0;
    }

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
        switch (contatoreDialoghi){
            case 4:
            /*il trigger parte solo se è attivo un dialogo*/
                if (dialogo){
                    transizioniTutorial.SetTrigger("uscitaTutorial");
                    dialogo=false;
                    Debug.Log("case 4");  
                }
            break;

            default:
                Debug.Log("default");
                if (!dialogo)
                {
                    dialogo=true;
                    StartCoroutine(entra());
                }
                StopAllCoroutines();
                StartCoroutine(scrittura(dialoghi[contatoreDialoghi]));
                contatoreDialoghi++;
            break;
        }
        Debug.Log("contatore: "+contatoreDialoghi);
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

    IEnumerator entra (){
        transizioniTutorial.SetTrigger("ingressoTutorial");
        yield return new WaitForSeconds(1);
    }
}
