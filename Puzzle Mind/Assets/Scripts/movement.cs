using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float runSpeed = 20;
    public float jumpPower = 10;
    public int maxJumps = 1;
    public float checkRadius;

    private bool isGrounded;
    private bool isJumping = false;
    private float horizontal;
    private int jumpCount;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundObject;

    Rigidbody2D rb;
    BoxCollider2D coll;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        jumpCount = maxJumps;
    }

    // Update is called once per frame
    void Update()
    {
        getInput();
    }
    private void FixedUpdate()
    {
        Grounded();
        move();
    }
    private void Grounded()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundObject);
        if (isGrounded)
        {
            jumpCount = maxJumps;
        }
    }
    private void getInput()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }

    }
    private void move()
    {
        rb.velocity = new Vector2(horizontal * runSpeed, rb.velocity.y);
        if (isJumping && jumpCount > 0)
        {
            rb.AddForce(new Vector2(0f, jumpPower));
            jumpCount--;
        }
        isJumping = false;
    }
}
