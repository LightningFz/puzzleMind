using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// by Faraz
public class CameraScript : MonoBehaviour
{
    public GameObject player;
    [SerializeField]private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position - offset;
    }
}
