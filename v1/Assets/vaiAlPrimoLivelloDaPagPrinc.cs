using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vaiAlPrimoLivelloDaPagPrinc : MonoBehaviour
{
    public Animator trans;
    public float time = 1f; 

    public void scriptVaiAPrimolivelloDaPrinc () {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 2));
    }
    IEnumerator LoadLevel(int levelIndex) {
        trans.SetTrigger("start");
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(levelIndex);
    }
}
