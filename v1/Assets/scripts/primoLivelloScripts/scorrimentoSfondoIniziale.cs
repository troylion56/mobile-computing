using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorrimentoSfondoIniziale : MonoBehaviour
{
    public Vector2 posizioneIniziale;   //tipo vettore
    // Start is called before the first frame update
    void Start()
    {
        posizioneIniziale = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y>-11.3) {
            transform.position = new Vector2 (transform.position.x, transform.position.y-1.5f*Time.deltaTime);
        }
        else {
            transform.position= posizioneIniziale;
        }
        //!-----------debug---------------------------------------
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            transform.position=new Vector2(transform.position.x,11);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            transform.position=new Vector2(transform.position.x,-10.88f);
        }
        //!-----------debug---------------------------------------
    }
}
