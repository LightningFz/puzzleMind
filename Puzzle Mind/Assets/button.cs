using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public door dr;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")|| other.CompareTag("Box"))
        {
            Switch();
        }
    }
    void Switch()
    {
        if (dr.doorOpen == false)
        {
            dr.doorOpen = true;
        }
        else if (dr.doorOpen == true)
        {
            dr.doorOpen = false;
        }
    }

}
