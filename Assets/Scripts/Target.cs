using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public bool overlap;

    void OnTriggerEnter2D(Collider2D col)
    {
        // only if the tag is "Box" will we set the overlap is true 
        if (col.tag == "Box")   
            overlap = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        // if there is no longer an overlap (ex. box moved elsewhere), set overlap to false
        if (col.tag == "Box") 
            overlap = false;
    }
}
