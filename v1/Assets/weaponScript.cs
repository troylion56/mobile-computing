using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponScript : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPreFab;
    
    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        Instantiate(bulletPreFab, firePoint.position, firePoint.rotation);
    }

    public void onClick (){
        Shoot();
    }
    
}
