using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tornaSchermataPrincipale : MonoBehaviour
{
    public void vaiSchermataIniziale(){
        gameController.pausa=false;
        gameController.s11=false;
        gameController.s12=false;
        gameController.s13=false;
        Time.timeScale=1;
        SceneManager.LoadSceneAsync("SchermataIniziale");
    }
}
