using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class weaponScriptTutorial : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPreFab;
    public static bool stato;
    public Sprite caricamento0, caricamento1, caricamento2, caricamento3,caricamento4;
    public int colpiDisponibili;
    public Button pulsante;
    public Image tasto;
    public float rate = 1f;
    public int timeRicarica;
    private int contatoreSpari=0;       //variabile che conta gli spari effettuati durante il tutorial dello shooting
    public gestoreTestoTutorial tutorial;
    private bool singolo=true;
    public SpriteState st;
    public Sprite onclick1,onclick2,onclick3, onclick4;
    private void Start() {
        stato = true;
        colpiDisponibili = 4;            // si inizia con il caricatore pieno
        st.pressedSprite = onclick4;
        pulsante.spriteState=st;

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
        contatoreSpari++;

    }

    public void Update() {
        rate += Time.deltaTime;
        if(rate > timeRicarica && colpiDisponibili < 4) {
            colpiDisponibili ++;
            cambiaSprite();
            rate = 0;       // faccio riniziare il tempo di ricarica
        }

        if (contatoreSpari>4&&gestoreTestoTutorial.contatoreDialoghi==47&&singolo){
            singolo=false;
            chiamaTutorial();
        }
    }

    public void cambiaSprite() {
        if(colpiDisponibili == 1) {
            pulsante.interactable = true;
            tasto.sprite = caricamento1;
            st.pressedSprite = onclick1;
            pulsante.spriteState=st;
        }
        else if(colpiDisponibili == 2) {
            tasto.sprite = caricamento2;
            st.pressedSprite = onclick2;
            pulsante.spriteState=st;
        }
        else if(colpiDisponibili == 3) {
            tasto.sprite = caricamento3;
            st.pressedSprite = onclick3;
            pulsante.spriteState=st;
        }
        else if(colpiDisponibili == 4) {
            tasto.sprite = caricamento4;
            st.pressedSprite = onclick4;
            pulsante.spriteState=st;
        }
        else if(colpiDisponibili == 0) {
            tasto.sprite = caricamento0;
            pulsante.interactable = false;
        }

    }

    void chiamaTutorial(){
        gestoreTestoTutorial.contatoreDialoghi++;
        tutorial.scrivi();
    }
}
