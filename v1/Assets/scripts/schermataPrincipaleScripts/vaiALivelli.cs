using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vaiALivelli : MonoBehaviour
{
    public soundManager SManager;
    public void scriptVaiAlivelli () {
        SManager.playPausa();
        SceneManager.LoadSceneAsync("livelli");
    }
}
