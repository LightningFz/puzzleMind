using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// by Faraz
public class dive : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.gravityScale = 5;
        }
    rb.gravityScale = 3;
    }
    public void getInput()
    {

    }
}
