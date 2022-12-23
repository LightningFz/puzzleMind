using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fan : MonoBehaviour
{
    public bool fanon = false;
   
   void OnTriggerEnter2D(Collider2D other) {
        other.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 3 , ForceMode2D.Impulse);
        Debug.Log("real");
    }

    // void Update(Collider2D other){
    //     if(fanon == true){
    //          void OnTriggerEnter2D(Collider2D other) {
    //             other.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 3 , ForceMode2D.Impulse);
    //          }
    //     }
    //     else{
    //         void OnTriggerEnter2D(Collider2D other) {
    //             other.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 3 , ForceMode2D.Impulse);
    //          }
    //     }
    // }
}


    
