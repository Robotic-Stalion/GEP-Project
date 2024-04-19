using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    
    public CharacterController controller;
    
    public float speed = 5f;
    public float gravity = -10f;
    public float jumpHeight = 0.1f;
    
    Vector3 velocity;
    private bool isGrounded;
    
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    
    // Update is called once per frame
    void Update()
    {
        //grounded check
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
        // takes input from unity controller
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        //moves player based on transform
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(Vector3.ClampMagnitude(move, 1) * speed * Time.deltaTime);
        
        velocity.y += gravity * Time.fixedDeltaTime;
        controller.Move(velocity * Time.deltaTime);
        
        //jumps
        if (Input.GetButton("Jump") && isGrounded)
        {
            velocity.y += Mathf.Sqrt(jumpHeight * -2f * gravity);
            
        }
    }
}
