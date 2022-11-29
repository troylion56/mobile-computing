using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gestoreBenzina : MonoBehaviour
{
    public Slider benzina;
    // Start is called before the first frame update
    void Start()
    {
        benzina.value=100;
    }

    public void carica (int ricarica){
        benzina.value=benzina.value+ricarica;
    }

    private void Update() {
        benzina.value=benzina.value-0.1f;
    }
}
