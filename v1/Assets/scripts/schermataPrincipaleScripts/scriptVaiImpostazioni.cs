using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scriptVaiImpostazioni : MonoBehaviour
{
    public soundManager SManager;
    public void vaiImpostazioni () {
        SManager.playPausa();
        SceneManager.LoadSceneAsync("impostazioni");
    }
}

