using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanbutton : MonoBehaviour
{
    public fan fn;
    public Sprite buttonPressed;
    public Sprite buttonUnpressed;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")|| other.CompareTag("Box"))
        {
            Switch();
        }
    }
    void Switch()
    {
        if (fn.fanOn == false)
        {
            fn.fanOn = true;
        }
        else if (fn.fanOn == true)
        {
            fn.fanOn = false;
        }
    }
    void Update()
    {
        if (fn.fanOn == true){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = buttonPressed;
        }else if (fn.fanOn == false){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = buttonUnpressed;
        }
    }

}
