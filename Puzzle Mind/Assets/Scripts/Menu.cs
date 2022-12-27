using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public Sprite escapeShown;
    public Sprite escapeHidden;
    public bool escape = false;
    // Start is called before the first frame update
    void Start()
    {
        startScreen();
    }

    // Update is called once per frame
    void Update()
    {
        getInput();
        escapeScreen();
    }
    private void getInput()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (escape == true)
            {
                escape = false;
                Debug.Log("test for true to false");
            }else if (escape == false)
            {
                escape = true;
                Debug.Log("test for false to true");
            }
        }
    }
    private void startScreen()
    {

    }
    private void escapeScreen()
    {
        if (escape == true){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = escapeShown;
        }else if (escape == false){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = escapeHidden;
        }
    }
}