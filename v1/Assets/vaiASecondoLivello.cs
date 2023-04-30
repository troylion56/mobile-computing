using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class vaiASecondoLivello : MonoBehaviour
{
    public soundManager SManager;
    public void vaiALivello2(){
        gameController.pausa=false;
        gameController.fineLiv=false;
        Time.timeScale=1;
        SManager.playPausa();
        SceneManager.LoadSceneAsync("SecondoLivello");
    }
}
