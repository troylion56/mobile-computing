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
    public Image tasto;
    public float rate = 1f;
    public int timeRicarica;


    private void Start() {
       stato = true;
       colpiDisponibili = 3;            // si inizia con il caricatore pieno

    }

    void Shoot()
    {
        Instantiate(bulletPreFab, firePoint.position, firePoint.rotation);
    }

    public void onClick (){
        Shoot();
        colpiDisponibili--;
        cambiaSprite();
        rate = 0;

    }

    public void Update() {
        rate += Time.deltaTime;
        if(rate > timeRicarica && colpiDisponibili < 4) {
            colpiDisponibili ++;
            cambiaSprite();
            rate = 0;       // faccio riniziare il tempo di ricarica
        }
    }

    public void cambiaSprite() {
        if(colpiDisponibili == 1) {
            pulsante.interactable = true;
            tasto.sprite = caricamento1;
        }
        else if(colpiDisponibili == 2) {
            tasto.sprite = caricamento2;
        }
        else if(colpiDisponibili == 3) {
            tasto.sprite = caricamento3;
        }
        else if(colpiDisponibili == 0) {
            tasto.sprite = caricamento0;
            pulsante.interactable = false;
        }

    }

    
}
