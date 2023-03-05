using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class esciDaLvl : MonoBehaviour
{
    public void vaiSchermataIniziale(){
        gameController.pausa=false;
        gameController.s1=false;
        gameController.s2=false;
        gameController.s3=false;
        Time.timeScale=1;
        SceneManager.LoadSceneAsync("SchermataIniziale");
    }
}
