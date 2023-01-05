using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class healthBar : MonoBehaviour
{

    public Sprite health0, health1, health2, health3, health4;
    public Transform barPosition;
    public SpriteRenderer immagine;



    // Start is called before the first frame update
    void Start()
    {
        immagine.sprite = health4;
    }


    // Update is called once per frame
    void Update()
    {
        if(enemyScript.health == 0) {
            immagine.sprite = health0;
        }
        if(enemyScript.health == 1) {
            immagine.sprite = health1;
        }
        if(enemyScript.health == 2) {
            immagine.sprite = health2;
        }
        if(enemyScript.health == 3) {
            immagine.sprite = health3;
        }
        if(enemyScript.health == 4) {
            immagine.sprite = health4;
        }
    }

}
