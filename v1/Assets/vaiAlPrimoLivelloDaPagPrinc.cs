using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vaiAlPrimoLivelloDaPagPrinc : MonoBehaviour
{
    public soundManager SManager;
    public Animator trans;
    public float time = 1f; 

    public void scriptVaiAPrimolivelloDaPrinc () {
        SManager.playPausa();
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 2));
    }
    IEnumerator LoadLevel(int levelIndex) {
        trans.SetTrigger("start");
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(levelIndex);
    }
}
