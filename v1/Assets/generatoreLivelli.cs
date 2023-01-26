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
    private float pausa=0.40f;
    public GameObject nemico1;
    private bool f1=false;          //flag di start per le sezioni del livello

    void Start(){
        
    }

    private void Update() {
    }

    public void onClick(){
        StartCoroutine(livello_pt1());
        if (nemico1==null&&!f1){
            /*dopo il completamento del primo encounter*/
            f1=true;
            StartCoroutine(livello_pt2());
        }
    }

    IEnumerator livello_pt1(){
        /*crea(asteronide,false,false,true,false,false);
        yield return new WaitForSeconds(pausa*2);
        crea(asteronide,false,true,false,true,false);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,true,false,false,false,true);
        
        yield return new WaitForSeconds(pausa);
        crea(asteronide,true,false,true,true,true);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,true,false,false,true,true);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,true,true,false,false,true);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,true,true,true,false,true);
        yield return new WaitForSeconds(pausa);

        crea(asteronide,false,false,false,false,true);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,false,false,false,false,true);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,false,false,false,true,true);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,true,false,true,true,true);

        yield return new WaitForSeconds(pausa);
        crea(collBenzina,false,true,false,false,false);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,false,false,true,false,false);
        yield return new WaitForSeconds(pausa);
        crea(stella1,false,false,false,true,false);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,false,false,true,false,false);*/

        yield return new WaitForSeconds(pausa);
        crea(asteronide,false,true,true,true,false);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,false,false,true,false,false);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,true,false,true,false,true);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,false,false,true,false,false);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,false,true,true,true,false);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,false,false,true,false,false);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,true,false,true,false,true);
        crea(collMissili,false,false,false,true,false);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,false,false,true,false,false);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,false,true,true,true,false);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,false,false,true,false,false);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,true,false,false,false,true);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,false,false,true,false,false);
        crea(collBenzina,true,false,false,false,true);
        yield return new WaitForSeconds(pausa);
        crea(asteronide,false,true,true,true,false);
        yield return new WaitForSeconds(pausa*10);
        nemico1.SetActive(true);
    }

    IEnumerator livello_pt2(){
        crea(asteronide,false,false,true,false,false);
        yield return new WaitForSeconds(pausa);
    }
    private void crea(GameObject oggetto,bool s1,bool s2,bool s3,bool s4,bool s5){
        /*funzione di supporto per istanziare un oggetto*/
        if (s1){
            Instantiate(oggetto,sp1.transform.position,sp1.rotation);
        }
        
        if (s2){
            Instantiate(oggetto,sp2.transform.position,sp1.rotation);
        }

        if (s3){
            Instantiate(oggetto,sp3.transform.position,sp1.rotation);
        }
        
        if (s4){
            Instantiate(oggetto,sp4.transform.position,sp1.rotation);
        }

        if (s5){
            Instantiate(oggetto,sp5.transform.position,sp1.rotation);
        }
    }
}
