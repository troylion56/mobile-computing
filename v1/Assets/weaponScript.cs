using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponScript : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPreFab;
    public static bool stato;

    private void Start() {
        stato=false;
    }
    void Shoot()
    {
        Instantiate(bulletPreFab, firePoint.position, firePoint.rotation);
    }

    public void onClick (){
        Shoot();
    }
    
}
