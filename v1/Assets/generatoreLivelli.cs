using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatoreLivelli : MonoBehaviour
{

    public Transform sp1;
    public Transform sp2;
    public Transform sp3;
    public Transform sp4;
    public Transform sp5;
    public GameObject asteronide;
    public GameObject nemico;
    public GameObject collBenzina;
    public GameObject collMissili;
    public GameObject stella1;
    public GameObject stella2;
    public GameObject stella3;
    public float pausa=100.5f;

    void Start(){
        
    }

    public void onClick(){
        StartCoroutine(livello());
    }

    IEnumerator livello(){
        Instantiate(asteronide,sp3.transform.position,sp1.rotation);
        yield return new WaitForSeconds(pausa+5);
        Instantiate(asteronide,sp2.transform.position,sp1.rotation);
        Instantiate(asteronide,sp4.transform.position,sp1.rotation);
        yield return new WaitForSeconds(pausa);
        Instantiate(asteronide,sp1.transform.position,sp1.rotation);
        Instantiate(asteronide,sp5.transform.position,sp1.rotation);
        
        yield return new WaitForSeconds(pausa);
        Instantiate(asteronide,sp1.transform.position,sp1.rotation);
        Instantiate(asteronide,sp3.transform.position,sp1.rotation);
        Instantiate(asteronide,sp4.transform.position,sp1.rotation);
        Instantiate(asteronide,sp5.transform.position,sp1.rotation);
        yield return new WaitForSeconds(pausa);
        Instantiate(asteronide,sp1.transform.position,sp1.rotation);
        Instantiate(asteronide,sp4.transform.position,sp1.rotation);
        Instantiate(asteronide,sp5.transform.position,sp1.rotation);
        yield return new WaitForSeconds(pausa);
        Instantiate(asteronide,sp1.transform.position,sp1.rotation);
        Instantiate(asteronide,sp2.transform.position,sp1.rotation);
        Instantiate(asteronide,sp5.transform.position,sp1.rotation);
        yield return new WaitForSeconds(pausa);

        Instantiate(asteronide,sp5.transform.position,sp1.rotation);
        yield return new WaitForSeconds(pausa);
        Instantiate(asteronide,sp5.transform.position,sp1.rotation);
        yield return new WaitForSeconds(pausa);
        Instantiate(asteronide,sp5.transform.position,sp1.rotation);
        Instantiate(asteronide,sp4.transform.position,sp1.rotation);
        yield return new WaitForSeconds(pausa);
        Instantiate(asteronide,sp5.transform.position,sp1.rotation);
        Instantiate(asteronide,sp4.transform.position,sp1.rotation);
        Instantiate(asteronide,sp3.transform.position,sp1.rotation);
        yield return new WaitForSeconds(pausa);
        Instantiate(collBenzina,sp4.transform.position,sp1.rotation);

        yield return new WaitForSeconds(pausa);
        Instantiate(asteronide,sp2.transform.position,sp1.rotation);
        yield return new WaitForSeconds(pausa);
        Instantiate(asteronide,sp2.transform.position,sp1.rotation);
        Instantiate(stella1,sp2.transform.position,sp1.rotation);
    }
}
