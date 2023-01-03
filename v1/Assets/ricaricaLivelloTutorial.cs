using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ricaricaLivelloTutorial : MonoBehaviour
{
    public void ricLivello (){
        gameController.pausa=false;
        gameController.s1=false;
        gameController.s2=false;
        gameController.s3=false;
        Time.timeScale=1;
        gestoreTestoTutorial.contatoreDialoghi=0;
        gestoreTestoTutorial.dialogo=true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
