using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class musicController : MonoBehaviour
{
    [Header("       -----Musica----")]
    public AudioSource musicaEsterna;
    private static musicController istance;
    private bool esterno;

    private void Start() {
         Debug.Log("aaaaaaaaaaaaaaaa");
    }
    private void Awake() {
        if(SceneManager.GetActiveScene().name=="PrimoLivello" || SceneManager.GetActiveScene().name=="Secondoivello" || SceneManager.GetActiveScene().name=="tutorial") {
            esterno=false;
        }else{
            esterno=true;
        }

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
