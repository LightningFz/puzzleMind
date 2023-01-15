using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformControlertwo : MonoBehaviour
{
    public Transform posA, posB, posC;
    public int Speed;
    public float timer;
    Vector2 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        targetPos=posB.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, posA.position) < .1f) Invoke("Action1a", timer);
        if (Vector2.Distance(transform.position, posB.position) < .1f) Invoke("Action2a", timer);
        if (Vector2.Distance(transform.position, posC.position) < .1f) Invoke("Action3a", timer);

        transform.position = Vector2.MoveTowards(transform.position, targetPos, Speed * Time.deltaTime);
    }
    void Action1a()
    {
        targetPos = posC.position;
    }
    void Action2a()
    {
        targetPos = posA.position;
    }
    void Action3a()
    {
        targetPos = posB.position;
    }
}

