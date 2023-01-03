using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gestoreVita : MonoBehaviour
{
  public Animator transizione; 
  public GameObject player;
  public Slider vita;
  public Gradient gradiente;
  public Image colore;
  public int danno = 10;

  public void setMaxHp(int maxHp){
      /*setta il valore massimo dello slider vita a maxHp*/
      vita.maxValue=maxHp;
      /*setta il valore attuale della vita al massimo*/
      vita.value=maxHp;
      /*gestisce il gradiente della vita*/
      colore.color=gradiente.Evaluate(1f);
   }

   private void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag("enemyShot")){
            colpisci(col.GetComponent<proiettili>());
        }
    }

    private void colpisci(proiettili proiettile) {
        if(proiettile is proiettili) {
            Debug.Log("Player colpito");
            danneggia();
        }
    }


  public void danneggia(){
        Debug.Log("Player danneggiato");
        /*sottrae del valore attuale della vita il danno subito*/
        vita.value=vita.value-danno;
        /*gestisce il gradiente della vita*/
        colore.color=gradiente.Evaluate(vita.normalizedValue);

        if(vita.value==0) {
            Debug.Log("Player morto");
            Destroy(player);
            gameController.pausa=true;
            Time.timeScale=0f;
            transizione.SetTrigger("triggerMorte");
        }
   }

   
}
