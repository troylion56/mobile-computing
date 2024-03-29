using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipeTutorial : MonoBehaviour
{

    private Vector2 posIniziale;
    private Vector2 posAttuale;
    private Vector2 posFinale;
    private bool stopTouch=false;
    public Transform posizione;
    public float swipeTime;
    public float tapTime;
    public Animator spostamento;   
    public gestoreTestoTutorial tutorial;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(!gestoreTestoTutorial.dialogo){
            if (Input.GetKeyDown(KeyCode.A))
        {
                    if (posizione.position.x==0)
                    {
                        spostamento.SetTrigger("vaiSx");
                    }
                    if (posizione.position.x==0.9f)
                    {
                        spostamento.SetTrigger("tornaDx");
                    }
                    if (posizione.position.x==-0.9f)
                    {
                        spostamento.SetTrigger("vaiSSx");
                    }
                    if (posizione.position.x==1.8f)
                    {
                        spostamento.SetTrigger("tornaDDx");
                    }
                    if (posizione.position.x==-1.8f)
                    {
                        spostamento.SetTrigger("vaiSSSx");
                        if (gestoreTestoTutorial.contatoreDialoghi==4){
                            /*se il tutorial si trova nella prima pausa registro lo spostamento*/
                            chiamaTutorial();
                        }
                    }
            Debug.Log("sinistra");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (posizione.position.x==0)
            {
                    spostamento.SetTrigger("vaiDx");
                }
                if (posizione.position.x==0.9f)
                {
                    spostamento.SetTrigger("vaiDDx");
                }
                if (posizione.position.x==-0.9f)
                {
                    spostamento.SetTrigger("tornaSx");
                }
                if (posizione.position.x==1.8f)
                {
                    spostamento.SetTrigger("vaiDDDx");
                        if (gestoreTestoTutorial.contatoreDialoghi==4){
                            /*se il tutorial si trova nella prima pausa registro lo spostamento*/
                            chiamaTutorial();
                        }
                }
                if (posizione.position.x==-1.8f)
                {
                    spostamento.SetTrigger("tornaSSx");
                }
            Debug.Log("destra");
        }

        if (Input.touchCount>0&&Input.GetTouch(0).phase==TouchPhase.Began)
        {
            posIniziale=Input.GetTouch(0).position;
            Debug.Log("posizione: "+posIniziale.y);
        }

        if (Input.touchCount>0&&Input.GetTouch(0).phase==TouchPhase.Moved)
        {
            posAttuale=Input.GetTouch(0).position;
            Vector2 distanza=posAttuale-posIniziale;

            if (!stopTouch&&posIniziale.y>300)
            {
                
                if (distanza.x<-swipeTime)
                {
                    if (posizione.position.x==0)
                    {
                        spostamento.SetTrigger("vaiSx");
                    }
                    if (posizione.position.x==0.9f)
                    {
                        spostamento.SetTrigger("tornaDx");
                    }
                    if (posizione.position.x==-0.9f)
                    {
                        spostamento.SetTrigger("vaiSSx");
                    }
                    if (posizione.position.x==1.8f)
                    {
                        spostamento.SetTrigger("tornaDDx");
                    }
                    if (posizione.position.x==-1.8f)
                    {
                        spostamento.SetTrigger("vaiSSSx");
                        if (gestoreTestoTutorial.contatoreDialoghi==4){
                            /*se il tutorial si trova nella prima pausa registro lo spostamento*/
                            chiamaTutorial();
                        }
                    }
                    Debug.Log("sinistra");
                    stopTouch=true;
                }
                if (distanza.x>swipeTime)
                {

                    if (posizione.position.x==0)
                    {
                        spostamento.SetTrigger("vaiDx");
                    }
                    if (posizione.position.x==0.9f)
                    {
                        spostamento.SetTrigger("vaiDDx");
                    }
                    if (posizione.position.x==-0.9f)
                    {
                        spostamento.SetTrigger("tornaSx");
                    }
                    if (posizione.position.x==1.8f)
                    {
                        spostamento.SetTrigger("vaiDDDx");
                        if (gestoreTestoTutorial.contatoreDialoghi==4){
                            /*se il tutorial si trova nella prima pausa registro lo spostamento*/
                            chiamaTutorial();
                        }
                    }
                    if (posizione.position.x==-1.8f)
                    {
                        spostamento.SetTrigger("tornaSSx");
                    }
                    Debug.Log("destra");
                    stopTouch=true;
                }
            }
        }

        if (Input.touchCount>0&&Input.GetTouch(0).phase==TouchPhase.Ended)
        {
            stopTouch=false;
            posFinale=Input.GetTouch(0).position;

            Vector2 distanza=posFinale-posIniziale;

            if (Mathf.Abs(distanza.x)<tapTime && Mathf.Abs(distanza.y)<tapTime)
            {
                Debug.Log("y:"+posAttuale.y);
                Debug.Log("tap");
            }
        }
    }
    }
    
    void chiamaTutorial(){
        gestoreTestoTutorial.contatoreDialoghi++;
        tutorial.scrivi();
    }
}
