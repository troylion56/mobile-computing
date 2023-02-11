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
    public int danno = 1;
    public Animator animator;
    public static bool morto;

    public void Start() {
        morto = false;
        animator = GetComponent<Animator>();
    }

    public void Update() {
        if(gameController.pausa) {         // interrompi animazione se metti in pausa il gioco
            animator.SetBool("isAlive", false);
        }
        if(!gameController.pausa) {       // rimettila quando riprendi
            animator.SetBool("isAlive", true);
        }

        if(vita.value == 0) {
            morto = true;
            // StartCoroutine(destructionDelay());
            Debug.Log("vita scesa a zero");
        }

        if(morto) {
            Debug.Log("coroutine morte player attivata");
            morto = false;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            vita.value=0;
        } 
    }
    

    

  public void setMaxHp(int maxHp){
      /*setta il valore massimo dello slider vita a maxHp*/
      vita.maxValue=maxHp;
      /*setta il valore attuale della vita al massimo*/
      vita.value=maxHp;
      /*gestisce il gradiente della vita*/
      colore.color=gradiente.Evaluate(1f);
   }


  public void danneggia(int danno){
        Debug.Log("Player danneggiato");
        /*sottrae del valore attuale della vita il danno subito*/
        vita.value = vita.value - danno;
        /*gestisce il gradiente della vita*/
        colore.color = gradiente.Evaluate(vita.normalizedValue);
        
   }
}
