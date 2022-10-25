using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ricaricaLivello : MonoBehaviour
{
    public void ricLivello (){
        gameController.pausa=false;
        Time.timeScale=1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
