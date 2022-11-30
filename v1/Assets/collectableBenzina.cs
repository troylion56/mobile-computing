using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableBenzina : collect
{
    public gestoreBenzina script;
    private void OnTriggerEnter2D(Collider2D other) {
        script.carica(100);
    }
}
