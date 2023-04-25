using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptVaiSchermataIniziale : MonoBehaviour
{
    public soundManager SManager;
    public void vaiSchermataIniziale(){
        SManager.playPausa();
        SceneManager.LoadSceneAsync("SchermataIniziale");
    }
}
