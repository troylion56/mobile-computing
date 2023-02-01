using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEBUG_spostamentoQuadrato : MonoBehaviour
{
    void Update(){
        if (Input.GetKeyDown((KeyCode.RightArrow)))
        {
            StartCoroutine(spostaDx());
        }

        if (Input.GetKeyDown((KeyCode.LeftArrow)))
        {
            StartCoroutine(spostaSx());
        }
    }

    IEnumerator spostaDx (){
        while (transform.position.x<1.8f)
        {
            transform.position=new Vector2(transform.position.x+0.05f,transform.position.y);
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator spostaSx (){
        while (transform.position.x>-1.8f)
        {
            transform.position=new Vector2(transform.position.x-0.05f,transform.position.y);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
