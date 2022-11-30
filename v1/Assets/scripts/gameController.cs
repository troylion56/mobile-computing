using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public static bool pausa;
    
    public static bool s11;

    public static bool s12;

    public static bool s13;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fineLivello (){
        if (PlayerPrefs.GetInt("superStella1:1")==0&&s11){
            PlayerPrefs.SetInt("superStella1:1",1);
        }
        if (PlayerPrefs.GetInt("superStella1:2")==0&&s12){
            PlayerPrefs.SetInt("superStella1:2");
        }
        if (PlayerPrefs.GetInt("superStella1:3")==0&&s13){
            PlayerPrefs.SetInt("superStella1:3",1);
        }
    }
}
