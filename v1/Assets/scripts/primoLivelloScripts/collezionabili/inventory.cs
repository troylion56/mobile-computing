using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventory : MonoBehaviour
{
    public SpriteRenderer stella1, stella2, stella3;

    public Sprite stellinaColore;

    public gestoreBenzina scriptBenzina;
    private int stellineTot = 0;
    public Button buttonSparo;
    public Button buttonRazzo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider2D) {
        if(collider2D.CompareTag("collectable")){
            Collect(collider2D.GetComponent<collect>());
        }

        if(collider2D.CompareTag("ostacoli")){
            /*caso di collisione con ostacoli*/
            Debug.Log("asteroide colpito");
            Destroy(gameObject);
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
                gameController.s1=true;             
            }
            else if (canCollect is collectStellina2)
            {
                stellineTot++;
                stella2.sprite = stellinaColore;
                gameController.s2=true;
            }
            else if (canCollect is collectStellina3)
            {
                stellineTot++;
                stella3.sprite = stellinaColore;
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
            }
            else if (canCollect is collectShooting)
            {
                buttonSparo.interactable=true;
                Debug.Log("Ora puoi sparare");
            }
        }
           
    }
}
