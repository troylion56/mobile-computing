using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroide : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(!gameController.pausa){
            transform.position = new Vector2 (transform.position.x, transform.position.y-2.5f*Time.deltaTime);
        }

        if (transform.position.y<=-5.6f)
        {
            Destroy(gameObject);
        }
    }
}
