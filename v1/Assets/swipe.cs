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
    public Animator spostamento;
    public GameObject player;
    private float distanza=3f;

    private float[] posizioni= new float[5] {-1.8f,-0.9f,0f,0.9f,1.8f};
    public int posIndex=2;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {/*
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
                    }*/
            Debug.Log("sinistra");
            StopAllCoroutines();
            if (posIndex==0){
                /*se sono a margine dello schermo faccio effetto pacman*/
                posIndex=4;
                StartCoroutine(spostamentoSSx(posizioni[posIndex]));
            }else{
                posIndex--;
                StartCoroutine(spostamentoSx(distanza));
            }
            Debug.Log("index:"+posIndex);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {/*
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
                    }
                    if (posizione.position.x==-1.8f)
                    {
                        spostamento.SetTrigger("tornaSSx");
                    }*/
            Debug.Log("destra");
            StopAllCoroutines();
            if (posIndex==4){
                /*se sono a margine dello schermo faccio effetto pacman*/
                posIndex=0;
                StartCoroutine(spostamentoDDx(posizioni[posIndex]));
            }else{
                posIndex++;
                StartCoroutine(spostamentoDx(transform.position.x+0.3f,transform.position.y));
            }
            Debug.Log("index:"+posIndex);
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
                    /*swipe verso sinistra*//*
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
                    }*/
                    StopAllCoroutines();
                    if (posIndex==0){
                        /*se sono a margine dello schermo faccio effetto pacman*/
                        posIndex=4;
                        StartCoroutine(spostamentoSSx(posizioni[posIndex]));
                    }else{
                        posIndex--;
                        StartCoroutine(spostamentoSx(posizioni[posIndex]));
                    }
                    Debug.Log("sinistra");
                    stopTouch=true;
                }
                if (distanza.x>swipeTime)
                {
                    /*swipe verso destra*//*
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
                    }
                    if (posizione.position.x==-1.8f)
                    {
                        spostamento.SetTrigger("tornaSSx");
                    }*/
                    StopAllCoroutines();
                    if (posIndex==4){
                        /*se sono a margine dello schermo faccio effetto pacman*/
                        posIndex=0;
                        StartCoroutine(spostamentoDDx(posizioni[posIndex]));
                    }else{
                        posIndex++;
                        StartCoroutine(spostamentoDx(transform.position.x+0.3f,transform.position.y));
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

    IEnumerator spostamentoDx(float x,float y){
        /*effetto pacman veso destra*/
        transform.position = new Vector2 (transform.position.x+0.3f,transform.position.y);
        yield return new WaitForSeconds (0.001f);
        transform.position = new Vector2 (transform.position.x+0.3f,transform.position.y);
        yield return new WaitForSeconds (0.001f);
        transform.position = new Vector2 (transform.position.x+0.3f,transform.position.y);
        yield return new WaitForSeconds (0.001f);
    }

    IEnumerator spostamentoSx(float dist){
        /*spostamento temporizzato del player verso sinistra*/
        transform.position = new Vector2 (transform.position.x-0.3f,transform.position.y);
        yield return new WaitForSeconds (0.001f);
        transform.position = new Vector2 (transform.position.x-0.3f,transform.position.y);
        yield return new WaitForSeconds (0.001f);
        transform.position = new Vector2 (transform.position.x-0.3f,transform.position.y);
        yield return new WaitForSeconds (0.001f);
    }

    IEnumerator spostamentoDDx(float nuovaPosizione){
        /*spostamento temporizzato del player verso destra*/
        /*prima il player si sposta fuori da lo schermo verso destra*/
        transform.position = new Vector2 (transform.position.x+0.3f,transform.position.y);
        yield return new WaitForSeconds (0.001f);
        transform.position = new Vector2 (transform.position.x+0.3f,transform.position.y);
        yield return new WaitForSeconds (0.001f);
        transform.position = new Vector2 (transform.position.x+0.3f,transform.position.y);
        yield return new WaitForSeconds (0.001f);
       

        transform.position = new Vector2 (-2.7f,transform.position.y);

        /*il player rientra nello schermo da sisistra verso destra*/
        transform.position = new Vector2 (transform.position.x+0.3f,transform.position.y);
        yield return new WaitForSeconds (0.001f);
        transform.position = new Vector2 (transform.position.x+0.3f,transform.position.y);
        yield return new WaitForSeconds (0.001f);
        transform.position = new Vector2 (transform.position.x+0.3f,transform.position.y);
        yield return new WaitForSeconds (0.001f);
    }

    

    IEnumerator spostamentoSSx(float nuovaPosizione){
        /*spostamento temporizzato del player verso sinistra*/
        /*prima il player si sposta fuori da lo schermo verso sinistra*/
        transform.position = new Vector2 (transform.position.x-0.3f,transform.position.y);
        yield return new WaitForSeconds (0.001f);
        transform.position = new Vector2 (transform.position.x-0.3f,transform.position.y);
        yield return new WaitForSeconds (0.001f);
        transform.position = new Vector2 (transform.position.x-0.3f,transform.position.y);
        yield return new WaitForSeconds (0.001f);

        transform.position = new Vector2 (2.7f,transform.position.y);

        /*il player rientra nello schermo da destra verso sisistra*/
        transform.position = new Vector2 (transform.position.x-0.3f,transform.position.y);
        yield return new WaitForSeconds (0.001f);
        transform.position = new Vector2 (transform.position.x-0.3f,transform.position.y);
        yield return new WaitForSeconds (0.001f);
        transform.position = new Vector2 (transform.position.x-0.3f,transform.position.y);
        yield return new WaitForSeconds (0.001f);
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
