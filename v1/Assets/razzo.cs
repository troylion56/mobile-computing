using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class razzo : MonoBehaviour
{

    public Transform firePoint2;
    public GameObject razzooooPreFab;
    // Update is called once per frame
    public static bool stato;
    public Button Button1;
    private void Start() {
        stato=false;
        Button1.interactable=false;
    }
    public void Shoot () {
        Instantiate(razzooooPreFab, firePoint2.position, firePoint2.rotation);
    }
    
    public void DisableButtonOnClick() {
        Button1.interactable=false;
        stato=false;
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.R)){
            Shoot();
        }
    }
}