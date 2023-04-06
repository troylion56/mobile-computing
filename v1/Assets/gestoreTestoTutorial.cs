using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class gestoreTestoTutorial : MonoBehaviour
{
    public Animator player;
    public gestoreVitaTutorial vita;
    public GameObject nemico;
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
    private bool salta;
    
    [TextArea(3,10)]
    public string [] dialoghi=new string [10];
    
    public static int contatoreDialoghi=0;

    private bool primaMorte=true;          //flag per gestire il testo dopo la prima morte del player contro il nemico     default:true

    private void Start() {
        contatoreDialoghi=0;
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (!salta){
                salta=true;;
            }else{
                scrivi ();
                Debug.Log("tap");
            }
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            contatoreDialoghi=20;
        }

        if (nemico==null&&contatoreDialoghi==53){
            contatoreDialoghi=59;
            scrivi();
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
                    vita.setMaxHp(5);
                    transizioniTutorial.SetTrigger("uscitaTutorial");
                    dialogo=false;
                    nemico.SetActive(true);
                    Debug.Log("il nemico ha attraversato il mare");
                    Debug.Log("case 53");
                } 
            break;

            case 54:
                if (primaMorte){
                    if (!dialogo){
                        dialogo=true;
                        StartCoroutine(entra());
                    }
                    nemico.SetActive(false);
                    StopAllCoroutines();
                    StartCoroutine(scrittura(dialoghi[contatoreDialoghi]));
                    contatoreDialoghi++;
                    primaMorte=false;
                }else{
                    /*dopo la prima morte il dialogo cambia*/
                    contatoreDialoghi=57;
                    nemico.SetActive(false);
                    scrivi();
                }
                Debug.Log("case 54");
            break;

            case 58:
                if (dialogo){
                    contatoreDialoghi=53;
                    scrivi();
                    Debug.Log("case 58");
                } 
            break;

            case 65:
                if (dialogo){
                    StartCoroutine(fineTutorial());
                    Debug.Log("case 65");
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

    IEnumerator fineTutorial (){
        player.SetTrigger("volaInAlto");
        //yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync("livelli");
        yield return null;
    }

    IEnumerator scrittura (string dialogo){
        continua.SetActive(false);
        salta=false;
        tutorial.text="";
        foreach (char lettera in dialogo.ToCharArray()){
            if (salta)
            {
                tutorial.text="";
                tutorial.text=dialogo;
                break;
            }else{
                tutorial.text += lettera;
                yield return new WaitForSeconds(0.05f);
            }
        }
        continua.SetActive(true);
        scrittaAttesa.attesa();                 //animazione puntini scritta attesa
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
                if (!salta){
                    salta=true;;
                }else{
                    scrivi ();
                    Debug.Log("tap");
                }
            }
        }
    }
}
