using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class resetProgressiGioco : MonoBehaviour{

    public void reset() {

        PlayerPrefs.SetInt("superStella1:1",0);
        PlayerPrefs.SetInt("superStella1:2",0);
        PlayerPrefs.SetInt("superStella1:3",0);

        PlayerPrefs.SetInt("superStella2:1",0);
        PlayerPrefs.SetInt("superStella2:2",0);
        PlayerPrefs.SetInt("superStella2:3",0);

        PlayerPrefs.SetInt("superStella3:1",0);
        PlayerPrefs.SetInt("superStella3:2",0);
        PlayerPrefs.SetInt("superStella3:3",0);
    }
}
