using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fan : MonoBehaviour
{
    public bool fanOn = false;
    public int fanPower = 5;
    void OnTriggerStay2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            if (fanOn == true)
            {
                other.GetComponent<Rigidbody2D>().AddForce(Vector2.right * fanPower);
            }
        }
        if (other.CompareTag("Box"))
        {
            if (fanOn == true)
            {
                other.GetComponent<Rigidbody2D>().AddForce(Vector2.right * fanPower, ForceMode2D.Impulse);
            }
        }
    }
}


    
