using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vaiATerzoLivello : MonoBehaviour
{
    public void vaiALivello2(){
        gameController.pausa=false;
        gameController.fineLiv=false;
        Time.timeScale=1;
        SceneManager.LoadSceneAsync("TerzoLivello");
    }
}
