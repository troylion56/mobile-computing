using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorrimentoLivelli : MonoBehaviour
{
    public Vector2 poszioneIniziale;
    // Start is called before the first frame update
    void Start()
    {
        poszioneIniziale = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y>-11) {
            transform.position = new Vector2 (transform.position.x, transform.position.y-2f*Time.deltaTime);
        }
        else {
            transform.position= poszioneIniziale;
        } 
    }
}
