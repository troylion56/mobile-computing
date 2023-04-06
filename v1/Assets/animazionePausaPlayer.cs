using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animazionePausaPlayer : MonoBehaviour
{
    public Animator player;
    bool stato;
    // Start is called before the first frame update
    void Start(){
        stato=true;
    }

    // Update is called once per frame
    void Update(){
        
        if (gameController.pausa&&stato){
            player.SetTrigger("pausa");
            stato=false;
        }

        if (!gameController.pausa&&!stato){
            player.SetTrigger("play");
            stato=true;
        }

    }
}
