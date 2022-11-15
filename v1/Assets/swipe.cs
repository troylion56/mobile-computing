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

    // Update is called once per frame
    void Update()
    {
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
}
