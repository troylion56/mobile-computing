using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipe : MonoBehaviour
{
    private Vector2 posIniziale;
    private Vector2 posAttuale;
    private Vector2 posFinale;
    private bool stopTouch=false;
    public Transform posizione;
    public float swipeTime;
    public float tapTime;

    float [] posizioni=new float[5] {-1.8f, -0.9f, 0.0f, 0.9f,1.8f};
    
    int index=2;
    public Animator spostamento;   

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            index--;
            if (index<0)
            {
                index=4;
            }
            //!posizione.position=new Vector2(posizioni[index],posizione.position.y);
            spostamento.SetTrigger("vaiSx");
            Debug.Log("sinistra");
            //!spostamento.SetTrigger("torna");
            //!StartCoroutine(swipeSx());
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            index++;
            if (index>4)
            {
                index=0;
            }
            //!posizione.position=new Vector2(posizioni[index],posizione.position.y);
            spostamento.SetTrigger("vaiDx");
            Debug.Log("destra");
            //!spostamento.SetTrigger("torna");
            //!StartCoroutine(swipeDx());
        }

        if (Input.touchCount>0&&Input.GetTouch(0).phase==TouchPhase.Began)
        {
            posIniziale=Input.GetTouch(0).position;
        }

        if (Input.touchCount>0&&Input.GetTouch(0).phase==TouchPhase.Moved)
        {
            posAttuale=Input.GetTouch(0).position;
            Vector2 distanza=posAttuale-posIniziale;

            if (!stopTouch)
            {
                if (distanza.x<-swipeTime)
                {
                    index--;
                    if (index<0)
                    {
                        index=4;
                    }
                    posizione.position=new Vector2(posizioni[index],posizione.position.y);
                    spostamento.SetTrigger("vaiSx");
                    Debug.Log("sinistra");
                    stopTouch=true;
                }
                if (distanza.x>swipeTime)
                {
                    index++;
                    if (index>4)
                    {
                        index=0;
                    }
                    posizione.position=new Vector2(posizioni[index],posizione.position.y);
                    spostamento.SetTrigger("vaiDx");
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
                Debug.Log("tap");
            }
        }
    }

        IEnumerator swipeDx(){
        spostamento.SetTrigger("vaiDx");
        yield return new WaitForSeconds(0.20f);
        //!spostamento.SetTrigger("torna");
    }

    
    IEnumerator swipeSx(){
        spostamento.SetTrigger("vaiSx");
        yield return new WaitForSeconds(0.20f);
        //!spostamento.SetTrigger("torna");
    }
}
