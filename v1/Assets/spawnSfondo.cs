using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSfondo : MonoBehaviour
{
    public GameObject sfondo;

    public void generaSfondo(Quaternion n){
        Instantiate(sfondo,new Vector3(0,21,0),n);
    }
}
