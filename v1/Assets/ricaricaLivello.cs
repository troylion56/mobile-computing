using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ricaricaLivello : MonoBehaviour
{
    public void ricLivello (){
        StopAllCoroutines();
        gameController.pausa=false;
        gameController.fineLiv=false;
        gameController.s1=false;
        gameController.s2=false;
        gameController.s3=false;
        Time.timeScale=1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
