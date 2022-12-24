using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonHold : MonoBehaviour
{
    public door dr;
    public Sprite buttonPressed;
    public Sprite buttonUnpressed;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player")|| other.CompareTag("Box"))
        {
            dr.doorOpen = true;
        }
    }
   
   void OnTriggerExit2D(Collider2D other)
   {
        if (other.CompareTag("Player")|| other.CompareTag("Box"))
        {
            dr.doorOpen = false;
        }
   }
    void Update()
    {
        if (dr.doorOpen == true){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = buttonPressed;
        }else if (dr.doorOpen == false){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = buttonUnpressed;
        }
    }

}
