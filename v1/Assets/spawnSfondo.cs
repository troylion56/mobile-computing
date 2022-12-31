using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSfondo : MonoBehaviour
{
    public GameObject sfondo;
    public GameObject benzina;
    public GameObject razzo;
    public Transform sp1;
    public Transform sp2;
    public Transform sp3;
    public Transform sp4;
    public Transform sp5;
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

    public void spawnBenzianTutorial(){
        /*metodo utilizzato nel tutorial per generare i consumabili della benzina*/
        Instantiate(benzina,sp1.transform.position,sp3.rotation);
        Instantiate(benzina,sp2.transform.position,sp3.rotation);
        Instantiate(benzina,sp3.transform.position,sp3.rotation);
        Instantiate(benzina,sp4.transform.position,sp3.rotation);
        Instantiate(benzina,sp5.transform.position,sp3.rotation);
    }

        public void spawnRazziTutorial(){
        /*metodo utilizzato nel tutorial per generare i consumabili della benzina*/
        Instantiate(razzo,sp1.transform.position,sp3.rotation);
        Instantiate(razzo,sp2.transform.position,sp3.rotation);
        Instantiate(razzo,sp3.transform.position,sp3.rotation);
        Instantiate(razzo,sp4.transform.position,sp3.rotation);
        Instantiate(razzo,sp5.transform.position,sp3.rotation);
    }
}
