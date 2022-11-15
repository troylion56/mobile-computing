using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class razzo : MonoBehaviour
{

    public Transform firePoint2;
    public GameObject razzooooPreFab;
    // Update is called once per frame
    void Update() {

    }
    public void Shoot () {
        Instantiate(razzooooPreFab, firePoint2.position, firePoint2.rotation);

    }
}
