using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorrimentoSfondoIniziale : MonoBehaviour
{
    public Vector2 posizioneIniziale;   //tipo vettore
    public spawnSfondo controller;

    public bool raggiunto;
    // Start is called before the first frame update
    void Start()
    {
        raggiunto=false;  
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<-11&&!raggiunto) {
            raggiunto=true;
            controller.generaSfondo(transform.rotation);
        }
        if (transform.position.y<-22&&raggiunto)
        {
            Destroy(gameObject);
        }
        if(!gameController.pausa){
            transform.position = new Vector2 (transform.position.x, transform.position.y-2.5f*Time.deltaTime);
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
