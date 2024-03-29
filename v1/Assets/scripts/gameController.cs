using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameController : MonoBehaviour{
    public static bool pausa;
    public static bool fineLiv;


    public static bool s1;
    public static bool s2;
    public static bool s3;
    public Animator transizione;    //animazione delle cose che scompaiono
    public Animator trans;          //animazione del player che vola
    public Animator trans1;   

    
    void Update()
    {  
        if(Input.GetKeyDown(KeyCode.F)) {
            fineLivello();
            Debug.Log("Fine livello");
        }
    }

    IEnumerator wait() {
        yield return new WaitForSeconds(2f);
        Debug.Log("Sstai aspettando un po' di secondi");
    }



    public void fineLivello (){
        StartCoroutine(wait());         // aspetti qualche secondo che il player cada
        gameController.pausa=true;
        gameController.fineLiv=true;
        Time.timeScale=0f;

        transizione.SetTrigger("triggermov");
        trans.SetTrigger("volaInAlto");
        trans1.SetTrigger("stel");

        if(SceneManager.GetActiveScene().name=="PrimoLivello") {
            if (PlayerPrefs.GetInt("superStella1:1")==0&&s1){
                PlayerPrefs.SetInt("superStella1:1",1);
            }
            if (PlayerPrefs.GetInt("superStella1:2")==0&&s2){
                PlayerPrefs.SetInt("superStella1:2",1);
            }
            if (PlayerPrefs.GetInt("superStella1:3")==0&&s3){
                PlayerPrefs.SetInt("superStella1:3",1);
            }
        }

        if(SceneManager.GetActiveScene().name=="SecondoLivello") {
            if (PlayerPrefs.GetInt("superStella2:1")==0&&s1){
                PlayerPrefs.SetInt("superStella2:1",1);
            }
            if (PlayerPrefs.GetInt("superStella2:2")==0&&s2){
                PlayerPrefs.SetInt("superStella2:2",1);
            }
            if (PlayerPrefs.GetInt("superStella2:3")==0&&s3){
                PlayerPrefs.SetInt("superStella2:3",1);
            }
        }

        if(SceneManager.GetActiveScene().name=="TerzoLivello") {
            if (PlayerPrefs.GetInt("superStella3:1")==0&&s1){
                PlayerPrefs.SetInt("superStella3:1",1);
            }
            if (PlayerPrefs.GetInt("superStella3:2")==0&&s2){
                PlayerPrefs.SetInt("superStella3:2",1);
            }
            if (PlayerPrefs.GetInt("superStella3:3")==0&&s3){
                PlayerPrefs.SetInt("superStella3:3",1);
            }
        }   
    }
}
