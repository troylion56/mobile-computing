using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public gestoreVita vita;
    
    // Start is called before the first frame update
    void Start()
    {
        vita.setMaxHp(3);
    }

    // Update is called once per frame
    void Update()
    {
//!-----------------debug-------------------
        if (Input.GetKeyDown(KeyCode.Z))
        {
            vita.danneggia(1);
        }
    
//!-----------------debug-------------------
    }

    
}
