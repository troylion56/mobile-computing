using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class esciDaLvlFinito : MonoBehaviour
{
    public void tornaALivelli(){
        gameController.pausa=false;
        gameController.fineLiv=false;
        Time.timeScale=1;
        SceneManager.LoadSceneAsync("livelli");
    }
}
