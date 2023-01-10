using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vaiAlPrimoLivello : MonoBehaviour
{
    public Animator trans;
    public float time = 1f; 


    public void scriptVaiAPrimolivello () {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator LoadLevel(int levelIndex) {
        trans.SetTrigger("start");
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(levelIndex);
    }
}

