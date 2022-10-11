using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gestoreController : MonoBehaviour
{
    public GameObject player;
    public Slider controller;
    public GameObject pomello;
    // Start is called before the first frame update
    void Start()
    {
        controller.value=0;
    }

    public void spostaPersonaggio(){
        player.transform.position=new Vector2 (controller.value,player.transform.position.y);
        pomello.transform.position=new Vector2 (controller.value,pomello.transform.position.y);
    }
}
