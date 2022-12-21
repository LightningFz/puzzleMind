using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
  BoxCollider2D col;
  void Awake(){
    col = GetComponent<BoxCollider2D>();
  }
  public bool doorOpen;
  void Update(){
    if(doorOpen == true){

    }
  }
}
