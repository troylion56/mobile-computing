using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuPausa : MonoBehaviour
{
    public Button volume;
    public Animator aaa;
    public static bool isPausa;

    public void Start() {
        isPausa = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(vaiAVolume.isVolume) {
            aaa.SetTrigger("volume");
            StartCoroutine(animationDelay());
        }
        if(backPausePanel.backPan) {
            aaa.SetTrigger("triggerASx");
            // StartCoroutine(animationDelay1());
        }

        if(mettiPlay.isPlay) {
            isPausa = false;
        }
        if(mettiPlay.isPlay) {
            isPausa = true;
        }

    }

    public IEnumerator animationDelay() {
        yield return new WaitForSeconds(0.8f);
        Time.timeScale = 0f;
        aaa.SetTrigger("triggerInPos");
    }
    public IEnumerator animationDelay1() {
        yield return new WaitForSeconds(0.1f);
        Time.timeScale = 0f;
        aaa.SetTrigger("triggerASx");
    }

}
