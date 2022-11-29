using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class razzo : MonoBehaviour
{

    public Transform firePoint2;
    public GameObject razzooooPreFab;
    // Update is called once per frame
    void Update() {

    }
    public void Shoot () {
        Instantiate(razzooooPreFab, firePoint2.position, firePoint2.rotation);
    }
    public Button Button1;
    public void DisableButtonOnClick() {
        Button1.interactable=false;
    }
}