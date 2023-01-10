using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fansprite : MonoBehaviour
{
    public fan fn;
    public Sprite fanRight;
    public Sprite fanLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(fn.fanDirection == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = fanRight;
        } else if(fn.fanDirection == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = fanLeft;
        }
    }
}
