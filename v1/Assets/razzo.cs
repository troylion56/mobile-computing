using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class razzo : MonoBehaviour
{

    public Transform firePoint2;
    public GameObject razzooooPreFab;

    public Sprite off ;
    public Image tasto;             //per passargli il bottone
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
        tasto.sprite = off;
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.R)){
            Shoot();
        }
    }
}