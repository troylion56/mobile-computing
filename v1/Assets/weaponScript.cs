using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weaponScript : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPreFab;
    public static bool stato;
    public Sprite caricamento0, caricamento1, caricamento2, caricamento3;
    public int colpiDisponibili;
    public SpriteRenderer shootingButton;
    public Button pulsante;
    public Image prova;


    private void Start() {
       stato = false;
       colpiDisponibili = 3;
    }

    void Shoot()
    {
        Instantiate(bulletPreFab, firePoint.position, firePoint.rotation);
    }

    public void onClick (){
        Shoot();
        colpiDisponibili--;
    }

    public void cambiaSprite() {
        if(colpiDisponibili == 1) {
            pulsante.interactable = true;
            prova.sprite = caricamento1;
        }
        else if(colpiDisponibili == 2) {
            prova.sprite = caricamento2;
        }
        else if(colpiDisponibili == 3) {
            prova.sprite = caricamento3;
        }
        else if(colpiDisponibili == 0) {
            prova.sprite = caricamento0;
            pulsante.interactable = false;
        }

    }

    
}
