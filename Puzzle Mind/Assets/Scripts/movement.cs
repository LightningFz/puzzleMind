using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float runSpeed = 20;
    public float jumpPower = 10;
    public int maxJumps = 1;
    public float checkRadius;

    public bool isFacingLeft = true;
    private bool isGrounded;
    private bool isGrounded2;
    private bool isJumping = false;
    private float horizontal;
    private float verticle;
    private int jumpCount;

    [SerializeField] private Transform groundCheckR;
    [SerializeField] private Transform groundCheckL;
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
        faceRight();
        getInput();
    }
    private void FixedUpdate()
    {
        Grounded();
        move();
    }
    private void Grounded()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckR.position, checkRadius, groundObject);
        isGrounded2 = Physics2D.OverlapCircle(groundCheckL.position, checkRadius, groundObject);
        if (isGrounded || isGrounded2)
        {
            jumpCount = maxJumps;
        }else{
            jumpCount = 0;
        }
    }
    private void getInput()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump") || Input.GetKeyDown("up") || Input.GetKeyDown("w"))
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
    public void faceRight()
    {
        if (horizontal < 0 && isFacingLeft)
        {
            Flip();
        }
        else if (horizontal > 0 && !isFacingLeft)
        {
            Flip();
        }
    }
    public void Flip()
    {
        isFacingLeft = !isFacingLeft;
        transform.Rotate(0f, 180, 0f);
    }
}
