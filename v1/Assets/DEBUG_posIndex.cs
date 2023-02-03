using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DEBUG_posIndex : MonoBehaviour
{
    public swipe script;

    GameObject scritta;

   // Update is called once per frame
    void Update(){
        GetComponent<Text>().text=script.posIndex.ToString();
    }
}
