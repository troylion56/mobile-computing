using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gestisciVolumeMusica : MonoBehaviour
{
    public Slider slider;
    public soundManager Smanager;
    public musicController MManager;

   void Start(){
        /*se esiste in memoria un precedente salvataggio del volume*/
        if (!PlayerPrefs.HasKey("volumeMusica")){
            /*se non esiste un salvataggio del volume lo imposto di default a 1 (100%)*/
            PlayerPrefs.SetFloat("volumeMusica",1);
            /*dopo aver assegnato il valore di default lo assegno come valore dello slider*/
            carica();
        }else{
            /*se esiste un precedente salvataggio lo assegno come valore dello slider*/
            carica();
        }
    }

    /*metodo che cambia il volume in base al valore attuale dello slider*/
    /*questo metodo viene chiamato ogi volta che il valore dellos lider viene modificato manualmente*/
    public void cambiaVolumeMusica(){
        /*assegno il valored ello slider al volume generale*/
        /*salvo in memoria la modifica*/
        salva();
        if (Smanager!=null){
            Smanager.cambiaVolume(slider.value);
        }

        if (MManager!=null){
            MManager.cambiaVolume(slider.value);
        }
    }

    private void carica (){
        /*carico da la memoria l'attuale valore dello slider*/
        slider.value=PlayerPrefs.GetFloat("volumeMusica");
    }

    private void salva (){
        /*salvo in memoria l'attuale valore dello slider*/
        PlayerPrefs.SetFloat("volumeMusica",slider.value);
    }
}
