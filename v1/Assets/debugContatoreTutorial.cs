using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class debugContatoreTutorial : MonoBehaviour
{
    void Update(){
        GetComponent<Text>().text=gestoreTestoTutorial.contatoreDialoghi.ToString();
    }
}
