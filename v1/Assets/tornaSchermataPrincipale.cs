using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tornaSchermataPrincipale : MonoBehaviour
{
    public void vaiSchermataIniziale(){
        gameController.pausa=false;
        Time.timeScale=1;
        SceneManager.LoadSceneAsync("SchermataIniziale");
    }
}
