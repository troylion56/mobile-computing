using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vaiTutorial2 : MonoBehaviour
{
    public soundManager SManager;
    public void vaiATutorial () {
        SManager.playPausa();
        SceneManager.LoadSceneAsync("tutorial");
    }
}
