using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryTutorial : MonoBehaviour
{
    public SpriteRenderer stella1, stella2, stella3,stella1GameOver, stella2GameOver, stella3GameOver;

    public Sprite stellinaColore, on ;
    public gestoreBenzinaTutorial scriptBenzina;
    private int stellineTot = 0;
    public Button buttonSparo;
    public Button buttonRazzo;
    public Animator transizione; 
    public gestoreTestoTutorial tutorial;
    public Image tasto;         //per passargli il bottone


    // Start is called before the first frame update
    void Start()
    {
        buttonRazzo.interactable=false;
    }

    private void OnTriggerEnter2D(Collider2D collider2D) {
        if(collider2D.CompareTag("collectable")){
            Collect(collider2D.GetComponent<collect>());
        }

        if(collider2D.CompareTag("ostacoli")){
            impatto(collider2D.GetComponent<ostacoli>());
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
            }
            else if (canCollect is collectStellina2)
            {
                stellineTot++;
                stella2.sprite = stellinaColore;
                stella2GameOver.sprite =stellinaColore;
            }
            else if (canCollect is collectStellina3)
            {
                stellineTot++;
                stella3.sprite = stellinaColore;
                stella3GameOver.sprite =stellinaColore;
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

    private void impatto (ostacoli oggetto){
        Debug.Log("impatto con asteroide tutorial");
        chiamaTutorial();
    }

    void chiamaTutorial(){
        gestoreTestoTutorial.contatoreDialoghi++;
        tutorial.scrivi();
    }
}
