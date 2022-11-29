using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class livelloBenzinaPlayer : MonoBehaviour
{
    public Slider benzina;

    // Update is called once per frame
    void Update()
    {
        if (benzina.value==0)
        {
            Destroy(gameObject);
        }
    }
}
