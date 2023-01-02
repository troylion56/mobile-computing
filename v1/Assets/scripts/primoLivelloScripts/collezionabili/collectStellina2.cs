using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectStellina2 : collect {
    Vector3 posizione;
    void Update()
    {

        if (transform.position.y<-7)
        {
            Destroy(gameObject);
        }

        if (!gameController.pausa)
        {
            transform.position = new Vector2 (transform.position.x, transform.position.y-2.5f*Time.deltaTime);
            
            posizione += new Vector3(0,2,0);
            transform.localEulerAngles=posizione;  
        }
    }
}