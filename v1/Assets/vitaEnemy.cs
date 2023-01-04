using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vitaEnemy : MonoBehaviour
{
    public GameObject nemico;
    public Slider vita;
    public Gradient gradiente;
    public Image colore;

    public int health = 100;
    public int danno = 100;

    public void setMaxHp(int maxHp){
      vita.maxValue = maxHp;       // imposti il valore massimo
      vita.value = maxHp;         // valore attuale
      colore.color = gradiente.Evaluate(1f);      // colore della barra

    }


    public void danneggia(){
        Debug.Log("nemico danneggiato");
        vita.value=vita.value-danno;            // prendi danno
        colore.color=gradiente.Evaluate(vita.normalizedValue);      // cambi colore

        if(vita.value==0) {     // MUORI
            Destroy(nemico);
            Debug.Log("nemico ucciso");

        }
    }

    
}
