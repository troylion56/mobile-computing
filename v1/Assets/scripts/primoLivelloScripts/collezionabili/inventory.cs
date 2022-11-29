using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventory : MonoBehaviour
{
    public SpriteRenderer stella1, stella2, stella3;

    public Sprite stellinaColore;

    private int stellineTot = 0;

    public Button buttonSparo;
    public Button buttonRazzo;
    // Start is called before the first frame update
    void Start()
    {
        buttonSparo.interactable=false;
        buttonRazzo.interactable=false;
    }

    private void OnTriggerEnter2D(Collider2D collider2D) {
        if(collider2D.CompareTag("collectable")){
            Collect(collider2D.GetComponent<collect>());
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
            }
            else if (canCollect is collectStellina2)
            {
                stellineTot++;
                stella2.sprite = stellinaColore;
            }
            else if (canCollect is collectStellina3)
            {
                stellineTot++;
                stella3.sprite = stellinaColore;
            }
            else if (canCollect is collectRazzo)
            {
                buttonRazzo.interactable=true;
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
