using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fandirection : MonoBehaviour
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
        if (fn.fanDirection == false)
        {
            fn.fanDirection = true;
        }
        else if (fn.fanDirection == true)
        {
            fn.fanDirection = false;
        }
    }
    void Update()
    {
        if (fn.fanDirection == true){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = buttonPressed;
        }else if (fn.fanDirection == false){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = buttonUnpressed;
        }
    }

}
