using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnOstacoli : MonoBehaviour
{
    public Transform sp1;
    public Transform sp2;
    public Transform sp3;
    public Transform sp4;
    public Transform sp5;
    public GameObject asteroide;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X)){
            Instantiate(asteroide,sp1.transform.position,sp1.rotation);
        }
        if(Input.GetKeyDown(KeyCode.C)){
            Instantiate(asteroide,sp2.transform.position,sp2.rotation);
        }
        if(Input.GetKeyDown(KeyCode.V)){
            Instantiate(asteroide,sp3.transform.position,sp3.rotation);
        }
        if(Input.GetKeyDown(KeyCode.B)){
            Instantiate(asteroide,sp4.transform.position,sp4.rotation);
        }
        if(Input.GetKeyDown(KeyCode.N)){
            Instantiate(asteroide,sp5.transform.position,sp5.rotation);
        }
    }
}
