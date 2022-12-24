using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSfondo : MonoBehaviour
{
    public GameObject sfondo;
    public GameObject benzina;
    public GameObject razzo;
    public Transform sp3;
    public void generaSfondo(Quaternion n){
        Instantiate(sfondo,new Vector3(0,21,0),n);
    }

//!--------------------------------------------------
    private void Update() {
        if (Input.GetKeyDown(KeyCode.L)){
            Instantiate(benzina,sp3.transform.position,sp3.rotation);
        }

        if (Input.GetKeyDown(KeyCode.K)){
            Instantiate(razzo,sp3.transform.position,sp3.rotation);
        }
    }
    
//!--------------------------------------------------
}
