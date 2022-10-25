using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponScript : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPreFab;
    public float timeScale;
    public float spawnTimer;

    // Update is called once per frame
    void Update()
    {
        spawnTimer+=Time.deltaTime;
        if(spawnTimer>timeScale)
        {
            Shoot();
            spawnTimer=0;
        }
    }

    void Shoot()
    {
        Instantiate(bulletPreFab, firePoint.position, firePoint.rotation);
    }
    
}
