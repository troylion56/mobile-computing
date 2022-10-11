using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour {

    private bool isCollected = false;   //we use to make sure that the collectable can t  be collected twice 

    public bool Collect (){ //
        if(isCollected)
            return false;

        isCollected = true;
        Destroy(gameObject);
        return true;
}
}