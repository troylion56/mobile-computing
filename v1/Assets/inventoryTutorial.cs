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
     public gestoreVitaTutorial vita;
     public soundManager SManager;


    // Start is called before the first frame update
    void Start()
    {
        buttonRazzo.interactable=false;
        vita.setMaxHp(5);
    }

    private void OnTriggerEnter2D(Collider2D collider2D) {
        if(collider2D.CompareTag("collectable")){
            SManager.playRaccoltaCollezionabili();
            Collect(collider2D.GetComponent<collect>());
        }

        if(collider2D.CompareTag("ostacoli")){
            impatto(collider2D.GetComponent<ostacoli>());
        }

        if(collider2D.CompareTag("proiettili")) {                 // caso di collisione con proettili nemico
            SManager.playDannoPlayer();
            if (gestoreTestoTutorial.contatoreDialoghi==53){
                vita.danneggia(1);
            }
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
                gestoreTestoTutorial.contatoreDialoghi=37;
                tutorial.scrivi();     
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
        if (gestoreTestoTutorial.contatoreDialoghi==8){
        /*caso di impatto durante il tutorial di spostamento*/
        Debug.Log("caso 1");
            gestoreTestoTutorial.contatoreDialoghi++;
            tutorial.scrivi();        
        }

        if (gestoreTestoTutorial.contatoreDialoghi==24){
        /*caso di impatto durante il tutorial sui razzi*/  
            if (razzo.stato){
            /*caso in cui il player si schianta senza sparare il razzo*/
            /*ripeto il tutorial senza spawnare i razzi*/
                Debug.Log("caso 2");
                gestoreTestoTutorial.contatoreDialoghi=27;
                tutorial.scrivi();  
            }else{
            /*caso in cui il player si schianta sparando il razzo*/
            /*ripeto il tutorial rispawnando i razzi*/
                Debug.Log("caso 3");
                gestoreTestoTutorial.contatoreDialoghi=25;
                tutorial.scrivi();  
            }
        }
    }
}
