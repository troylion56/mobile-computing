using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour{
    public static bool pausa;
    
    public static bool s1;
    public static bool s2;
    public static bool s3;

    void Start()
    {   
    }
    void Update()
    {   
    }

    public void fineLivello (){
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

        if(SceneManager.GetActiveScene().name=="TerzoLivello") {
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
    }
}
