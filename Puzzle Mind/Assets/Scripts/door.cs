using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public bool doorOpen = false;
    BoxCollider2D col;
    void Awake(){
          col = GetComponent<BoxCollider2D>();
    }
    void Update(){
        DoorCheck();
    }
    void DoorCheck() {
        if (doorOpen == true)
        {
            col.enabled = false;
        }
        else
        {
            col.enabled = true;
        }
    }
}
