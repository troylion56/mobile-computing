using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fineGioco : MonoBehaviour
{
    public void fine(){
        gameController.pausa=false;
        gameController.fineLiv=false;
        Time.timeScale=1;
        SceneManager.LoadSceneAsync("SchermataIniziale");
    }
}
