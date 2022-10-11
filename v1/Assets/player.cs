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

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("collect")) {
                Collect(other.GetComponent<collect>());
        }
    }

    private void Collect(collect collectable) {
        if(collectable.Collect()) {
            if(collectable is collectStellina1) {
                Debug.Log ("ho preso la stellina 1");
            }
            else if(collectable is collectStellina2) {
                Debug.Log ("ho preso la stellina 2");
            }
            else if(collectable is collectStellina3) {
                Debug.Log ("ho preso la stellina 3");
            }
        }
    }
}
