using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gestisciVolumeEffetti : MonoBehaviour
{
    public AudioSource spariPlayer;
    public AudioSource mortePlayer;
    public AudioSource spariNemici;
    public AudioSource morteNemici;
    public AudioSource effettiPausa;
    public Slider slider;

   void Start(){
        /*se esiste in memoria un precedente salvataggio del volume*/
        if (!PlayerPrefs.HasKey("volumeEffetti")){
            /*se non esiste un salvataggio del volume lo imposto di default a 1 (100%)*/
            PlayerPrefs.SetFloat("volumeEffetti",1);
            /*dopo aver assegnato il valore di default lo assegno come valore dello slider*/
            carica();
        }else{
            /*se esiste un precedente salvataggio lo assegno come valore dello slider*/
            carica();
        }
    }

    /*metodo che cambia il volume in base al valore attuale dello slider*/
    /*questo metodo viene chiamato ogi volta che il valore dellos lider viene modificato manualmente*/
    public void cambiavolumeEffetti(){
        /*assegno il valored ello slider al volume generale*/
//TODO        spariPlayer.volume=slider.value;
//TODO        mortePlayer.volume=slider.value;
//TODO        spariNemici.volume=slider.value;
//TODO        morteNemici.volume=slider.value;
//TODO        effettiPausa.volume=slider.value;
        /*salvo in memoria la modifica*/
        salva();
    }

    private void carica (){
        /*carico da la memoria l'attuale valore dello slider*/
        slider.value=PlayerPrefs.GetFloat("volumeEffetti");
    }

    private void salva (){
        /*salvo in memoria l'attuale valore dello slider*/
        PlayerPrefs.SetFloat("volumeEffetti",slider.value);
    }
}
