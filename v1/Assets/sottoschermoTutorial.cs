using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sottoschermoTutorial : MonoBehaviour
{
     public gestoreTestoTutorial tutorial;
     public spawnOstacoli spawn;

    private void OnTriggerEnter2D(Collider2D collider2D) {
        if (gestoreTestoTutorial.contatoreDialoghi==8){
            gestoreTestoTutorial.contatoreDialoghi=12;
            Debug.Log("asteroide tutorial sottoschermo");
            tutorial.scrivi();       
        }

        if (gestoreTestoTutorial.contatoreDialoghi==18)
        {
            gestoreTestoTutorial.contatoreDialoghi++;
            tutorial.scrivi(); 
        }

        if (gestoreTestoTutorial.contatoreDialoghi==24)
        {
            if(collider2D.CompareTag("collectable")){
            /*il player ha raccolto il razzo*/
                spawn.ostacoliCompleti();
            }

            if(collider2D.CompareTag("ostacoli")){
            /*tutorial completato*/
                gestoreTestoTutorial.contatoreDialoghi=29;
                tutorial.scrivi();  
            }
        }

        if (gestoreTestoTutorial.contatoreDialoghi==34){
        /*collisione con la stella durante il tutorial*/
        /*caso in cui il player non perende la stella durante il tutorial*/
            gestoreTestoTutorial.contatoreDialoghi++;
            tutorial.scrivi(); 
        }
    }
}
