using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnStelline : MonoBehaviour
{
    public GameObject stella1;
    public GameObject stella2;
    public GameObject stella3;
    public Transform sp3;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J)){
            Instantiate(stella1,sp3.transform.position,sp3.rotation);
            Debug.Log("1");
        }
        if(Input.GetKeyDown(KeyCode.H)){
            Instantiate(stella2,sp3.transform.position,sp3.rotation);
            Debug.Log("2");
        }
        if(Input.GetKeyDown(KeyCode.G)){
            Instantiate(stella3,sp3.transform.position,sp3.rotation);
            Debug.Log("3");
        }
    }
}
