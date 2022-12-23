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
            //while(check for rotation to be 90){
            //    transform.Rotate(0,0,0.1);
            //}
        }
        else
        {
            col.enabled = true;
            //while(check for rotation to be 0){
            //    transform.Rotate(0,0,-0.1);
            //}
        }
    }
}
