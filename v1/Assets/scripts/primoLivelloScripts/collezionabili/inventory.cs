using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventory : MonoBehaviour
{
    public SpriteRenderer stella1, stella2, stella3,stella1GameOver, stella2GameOver, stella3GameOver;

    public Sprite stellinaColore, on ;
    public gestoreBenzina scriptBenzina;
    private int stellineTot = 0;
    public Button buttonSparo;
    public Button buttonRazzo;
    public Animator transizione; 
    public Image tasto;         //per passargli il bottone
    public gestoreVita vita;
    public shake cameraShake;
    public Animator player;
    [SerializeField] private AudioSource raccorta, haivinto, proiettileDanno, meteoriti;



    public void Update() {
        /* fine livello */
        if(gameController.fineLiv && transform.position.y < 7) {
//TODO            haivinto.Play();
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.4f);
            Debug.Log("Sei nella parte dove il player dovrebbe volare in alto perchè hai finito il livello");
        }
        if(transform.position.y > 7) {
            Destroy(gameObject);            // distruggi se sale oltre lo schermo
        }

        
    }


    // Start is called before the first frame update
    void Start()
    {
        buttonRazzo.interactable = false;
        vita.setMaxHp(5);
    }


    /* gestione delle collisioni del player */
    private void OnTriggerEnter2D(Collider2D collider2D) {
        if(collider2D.CompareTag("collectable")){
            Collect(collider2D.GetComponent<collect>());
            Debug.Log("stellina raccolta");
        }

        if(collider2D.CompareTag("ostacoli")){                  // caso di collisione con ostacoli
            StartCoroutine(destructionDelay());
        }

        if(collider2D.CompareTag("proiettili")) {                 // caso di collisione con proettili nemico
            if (!(collider2D.GetComponent<proiettili>() is razzoShoting)){        
                vita.danneggia(1);
                StartCoroutine(cameraShake.Shaking(.10f, .05f));
    //TODO       proiettileDanno.Play();
            }
        }
    }


    private void Collect(collect canCollect)
    {
        if(canCollect.Collect())
        {
            if (canCollect is collectStellina1)
            {
 //TODO               raccorta.Play();
                stellineTot++;
                stella1.sprite = stellinaColore;
                stella1GameOver.sprite =stellinaColore;
                gameController.s1=true;
            }
            else if (canCollect is collectStellina2)
            {
 //TODO               raccorta.Play();
                stellineTot++;
                stella2.sprite = stellinaColore;
                stella2GameOver.sprite =stellinaColore;
                gameController.s2=true;
            }
            else if (canCollect is collectStellina3)
            {
 //TODO               raccorta.Play();
                stellineTot++;
                stella3.sprite = stellinaColore;
                stella3GameOver.sprite =stellinaColore;
                gameController.s3=true;
            }
            else if (canCollect is collectableBenzina)
            {
                scriptBenzina.carica(100);
                Debug.Log("benzina raccolta");
            }
            else if (canCollect is collectRazzo)
            {
                buttonRazzo.interactable=true;
                razzo.stato=true;
                Debug.Log("Ora puoi lancaira razzzzzzzzi");
                tasto.sprite = on;
            }
            else if (canCollect is collectShooting)
            {
                buttonSparo.interactable=true;
                Debug.Log("Ora puoi sparare");
            }
        }
           
    }
    public IEnumerator destructionDelay() {
        yield return new WaitForSeconds(0.1f);
        Time.timeScale = 0f;
        gameController.pausa=true;
        player.SetTrigger("dead");
        transizione.SetTrigger("triggerMorte");
        yield return new WaitForSeconds(0.6f);
        Destroy(gameObject);
    }
}
