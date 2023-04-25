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
        if(SceneManager.GetActiveScene().name=="PrimoLivello" || SceneManager.GetActiveScene().name=="Secondoivello" || SceneManager.GetActiveScene().name=="tutorial") {
            if (esterno){
                esterno=false;
                musicaEsterna.Stop();
            }
        }else{
            if (!esterno){
                esterno=true;
                musicaEsterna.Play();
            }
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
            musicaEsterna.Play();
        }
    }
    private void Awake() {


        if (esterno){
            musicaEsterna.Play();
        }else{
            musicaEsterna.Stop();
        }
        if(istance == null){
            istance=this;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
        }
    }    
}
