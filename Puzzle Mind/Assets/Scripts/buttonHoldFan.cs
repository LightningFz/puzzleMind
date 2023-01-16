using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonHoldFan : MonoBehaviour
{
    public fan fn;
    public Sprite buttonPressed;
    public Sprite buttonUnpressed;
    public bool pressed;
    public bool stopper = false;
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player")|| other.CompareTag("Box"))
        {
            Invoke("Action1", 0);
            pressed = true;
        }
    }
   void Action1()
   {
    if(stopper == false)
    {
        fn.fanPower = fn.fanPower + 1;
        stopper = true;
    }
   }
   void OnTriggerExit2D(Collider2D other)
   {
        if (other.CompareTag("Player")|| other.CompareTag("Box"))
        {
            pressed = false;
            stopper = false;
        }
   }
    void Update()
    {
        if (pressed == true){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = buttonPressed;
        }else if (pressed == false){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = buttonUnpressed;
        }
    }

}
