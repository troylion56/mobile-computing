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
    public int health;
    public int danno = 1;


    // Start is called before the first frame update
    void Start()
    {
        buttonRazzo.interactable = false;
        health = 4;
    }


    /* gestione delle collisioni del player */
    private void OnTriggerEnter2D(Collider2D collider2D) {
        if(collider2D.CompareTag("collectable")){
            Collect(collider2D.GetComponent<collect>());
            Debug.Log("stellina raccolta");
        }

        if(collider2D.CompareTag("ostacoli")){                  // caso di collisione con ostacoli
            Debug.Log("asteroide colpito");
            Destroy(gameObject);
            Time.timeScale=0f;
            transizione.SetTrigger("triggerMorte");
        }

        if(collider2D.CompareTag("proiettili")) {                 // caso di collisione con proettili nemico
            perdiVita(danno);
        }

    }



    public void perdiVita(int danno) {
        health -= danno;
        if(health <= 0) {
            Destroy(gameObject);            // muori
        }
    }



    private void Collect(collect canCollect)
    {
        if(canCollect.Collect())
        {
            if (canCollect is collectStellina1)
            {
                stellineTot++;
                stella1.sprite = stellinaColore;
                stella1GameOver.sprite =stellinaColore;
                gameController.s1=true;
            }
            else if (canCollect is collectStellina2)
            {
                stellineTot++;
                stella2.sprite = stellinaColore;
                stella2GameOver.sprite =stellinaColore;
                gameController.s2=true;
            }
            else if (canCollect is collectStellina3)
            {
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
                Debug.Log("Ora puoi lancaira razzzzzzzziiiiiiiiiiiiiiiiiiiiiiiiiiii");
                tasto.sprite = on;
            }
            else if (canCollect is collectShooting)
            {
                buttonSparo.interactable=true;
                Debug.Log("Ora puoi sparare");
            }
        }
           
    }

}
