using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableBenzina : collect
{
    public gestoreBenzina script;

    private void Update() {
        transform.position = new Vector2 (transform.position.x, transform.position.y-2.5f*Time.deltaTime);
    }
 //   private void OnTriggerEnter2D(Collider2D other) {
 //       script.carica(100);
 //   }
}
