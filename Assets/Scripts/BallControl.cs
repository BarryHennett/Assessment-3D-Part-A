using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Rigidbody rb;
    public float MoveForce = 10f;
    public float JumpHeight = 7f;
    public LayerMask groundLayer;
    public float raycastDistance = 0.6f;
    private float xInput;
    private float yInput;
    private float zInput;
    private bool Grounded;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {

        Jump();
        Grounds();

    }
    private void Grounds()
    {
        ProcessInputs();

        // checking ground
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, raycastDistance, groundLayer))
            Grounded = true;
        else
            Grounded = false;
    }

    private void Jump()
    {
        ProcessInputs();
        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && Grounded)
        {
            rb.AddForce(Vector3.up * JumpHeight, ForceMode.Impulse);
        }
    }
    public void FixedUpdate()
    {
        //triggers the characters movement
        Move();
    }

        private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0f, zInput) * MoveForce);
    }

    //x and z inputs
    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }



}
