using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ricaricaLivello : MonoBehaviour
{
    public void ricLivello (){
        gameController.pausa=false;
        gameController.s11=false;
        gameController.s12=false;
        gameController.s13=false;
        Time.timeScale=1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
