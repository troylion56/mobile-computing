using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class livelloBenzinaPlayer : MonoBehaviour
{
    public Animator transizione; 
    public Slider benzina;
    private bool distrutto;
    public GameObject player;

    private void Start() {
        distrutto=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (benzina.value==0&&!distrutto)
        {
            gameController.pausa=true;
            Time.timeScale=0f;
            cadi();
            transizione.SetTrigger("triggerMorte");
        }
    }

    public void cadi() {
        player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y - 0.07f);
        if(player.transform.position.y < -5.8f) {
            Destroy(player);
            distrutto=true;
        }
    }
}
