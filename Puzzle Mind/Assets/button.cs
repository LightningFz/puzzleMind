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
            Debug.Log(dr.doorOpen);
            if (dr.doorOpen == false)
            {
                dr.doorOpen = true;
                Debug.Log(dr.doorOpen);
            }
            else if (dr.doorOpen == true)
            {
                dr.doorOpen = false;
                Debug.Log(dr.doorOpen);
            }
            Debug.Log(dr.doorOpen);
        }
    }

}
