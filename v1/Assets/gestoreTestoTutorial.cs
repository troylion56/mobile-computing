using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gestoreTestoTutorial : MonoBehaviour
{
    public GameObject pulsanteShooting;
    public spawnStelline spawnStelle;
    public GameObject benzina;
    public GameObject pulsanteRazzi;
    public GameObject contenitoreStelle;
    public spawnSfondo scriptCollezionabili;
    public spawnOstacoli spawn;
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
    public continuaTutorial scrittaAttesa;
    private float pausa=0.05f;              //pausa tra la scrittura di una lettera e la successiva
    private bool saltabile=false;           //flag per indicare che il testo è saltabile
    
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

        if (Input.GetKeyDown(KeyCode.O))
        {
            contatoreDialoghi=20;
        }

        leggiTocco();
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

            case 8:
            /*il trigger parte solo se è attivo un dialogo*/
                if (dialogo){
                    transizioniTutorial.SetTrigger("uscitaTutorial");
                    dialogo=false;
                    spawn.spawnTutorial();
                    Debug.Log("case 8");  
                }
            break;

            case 11:
            /*caso in cui il player colpisce un asteroide durante il tutorial di movimento*/
                if (dialogo){
                    contatoreDialoghi=8;
                    Debug.Log("case 11");  
                    scrivi();
                }
            break;

            case 13:
                benzina.SetActive(true);
                StopAllCoroutines();
                StartCoroutine(scrittura(dialoghi[contatoreDialoghi]));
                contatoreDialoghi++;
            break;

            case 18:
                if (dialogo){
                    transizioniTutorial.SetTrigger("uscitaTutorial");
                    dialogo=false;
                    scriptCollezionabili.spawnBenzianTutorial();
                    Debug.Log("case 18");  
                }
            break;

            case 20:
                pulsanteRazzi.SetActive(true);
                StopAllCoroutines();
                StartCoroutine(scrittura(dialoghi[contatoreDialoghi]));
                contatoreDialoghi++;
                Debug.Log("case 20");  
            break;

            case 24:
                if (dialogo){
                    transizioniTutorial.SetTrigger("uscitaTutorial");
                    dialogo=false;
                    spawnOstacoli.singolo=true;
                    if (razzo.stato){
                    /*se il player ha un colpo carico spawno solo i meteoriti*/
                        spawn.ostacoliCompleti();
                    }else{
                    /*se il player non ha colpi carichi spawno anche i meteoriti*/
                        scriptCollezionabili.spawnRazziTutorial();
                    }
                    Debug.Log("case 24");  
                }
            break;

            case 26:
                if (dialogo){
                    contatoreDialoghi=24;
                    Debug.Log("case 25");  
                    scrivi();
                }
            break;

            case 28:
                if (dialogo){
                    contatoreDialoghi=24;
                    Debug.Log("case 28");  
                    scrivi();
                }
            break;

            case 32:
                contenitoreStelle.SetActive(true);
                StopAllCoroutines();
                StartCoroutine(scrittura(dialoghi[contatoreDialoghi]));
                contatoreDialoghi++;
                Debug.Log("case 32");  
            break;

            case 34:
                if (dialogo){
                    transizioniTutorial.SetTrigger("uscitaTutorial");
                    dialogo=false;
                    spawnStelle.stelleTutorial();
                    Debug.Log("case 34"); 
                } 
            break;

            case 36:
                if (dialogo){
                    contatoreDialoghi=34;
                    Debug.Log("case 36");  
                    scrivi();
                } 
            break;

            case 44:
                pulsanteShooting.SetActive(true);
                StopAllCoroutines();
                StartCoroutine(scrittura(dialoghi[contatoreDialoghi]));
                contatoreDialoghi++;
                Debug.Log("case 44");
            break;

            case 47:
            /*inizio tutorial shooting*/
                if (dialogo){
                    transizioniTutorial.SetTrigger("uscitaTutorial");
                    dialogo=false;
                    Debug.Log("case 47"); 
                } 
            break;

            case 53:
                if (dialogo){
                /*spawn dei nemici*/
                    Debug.Log("case 52");
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
        pausa=0.05f;                            //riposto al valore di default la pausa 
        saltabile=true;                         //il testo è ora saltabile
        continua.SetActive(false);
        tutorial.text="";
        foreach (char lettera in dialogo.ToCharArray()){
            tutorial.text += lettera;
            yield return new WaitForSeconds(pausa);
        }
        continua.SetActive(true);
        scrittaAttesa.attesa();                 //animazione puntini scritta attesa
        saltabile=false;                        //fine della scrittura del testo
    }

    IEnumerator entra (){
        transizioniTutorial.SetTrigger("ingressoTutorial");
        yield return new WaitForSeconds(1);
    }

    private void leggiTocco (){
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("contatore: "+contatoreDialoghi);
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
                if (saltabile){
                    pausa=0f;
                    saltabile=false;
                }else{
                    scrivi ();
                    Debug.Log("tap");
                }

            }
        }
    }
}
