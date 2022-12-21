using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    door dr;
    public void OnTriggerEnter2D(Collision2D other)
    {
        dr = gameObject.GetComponent<door>();
        if(other.transform.name == "Charecter1"){
            Debug.Log("fhfgj");
        }
    }
    
}
