using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class musicController : MonoBehaviour
{
    [Header("       -----Musica----")]
    public AudioSource musicaEsterna;
    private static musicController istance;
    private bool esterno=true;
    private bool livello=false;

    private void Update() {
        if(SceneManager.GetActiveScene().name=="PrimoLivello" || SceneManager.GetActiveScene().name=="SecondoLivello" || SceneManager.GetActiveScene().name=="tutorial") {
            if (esterno){
                esterno=false;
                musicaEsterna.Stop();
            }
        }else{
            if (!esterno){
                esterno=true;
                musicaEsterna.volume=PlayerPrefs.GetFloat("volumeMusica");
                musicaEsterna.Play();
            }
        }

        if (PlayerPrefs.GetFloat("volumeMusica") != musicaEsterna.volume){
            musicaEsterna.volume=PlayerPrefs.GetFloat("volumeMusica");
        }
    }

    public void stopMusic(){
        if (esterno){            
        esterno=false;
        musicaEsterna.Stop();
        }
    }

    public void playMusic(){
        if (!esterno){            
            esterno=true;
            musicaEsterna.volume=PlayerPrefs.GetFloat("volumeMusica");
            musicaEsterna.Play();
        }
    }

    //rende permanente il game object in ogni scena
    private void Awake() {
        if(istance == null){
            istance=this;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
        }
    }    

    public void cambiaVolume(float vol){
        Debug.Log("cambio volume musica esterna");
        musicaEsterna.volume=vol;
    }
}
