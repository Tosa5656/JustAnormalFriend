using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [SerializeField] float walkSpeed = 150f;
    [SerializeField] float runspeed = 200f;
    [SerializeField] float jumpPower = 200f;
    public bool ground;
    public Rigidbody rb;


    void FixedUpdate()
    {
        Walk();
        Jump();
    }

    private void Walk()
    {
        Vector3 velocity = new Vector3();

        if(Input.GetKey(KeyCode.W))
        {
            velocity += transform.forward*walkSpeed*Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.S))
        {
            velocity -= transform.forward*walkSpeed*Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.A))
        {
            velocity -= transform.right*walkSpeed*Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.D))
        {
            velocity += transform.right*walkSpeed*Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            velocity *= runspeed;
        } else 
        {
            velocity *= walkSpeed;
        }

        velocity.y = rb.velocity.y;
        
        rb.velocity = velocity;

    }

    private void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && ground)
        {
            rb.AddForce(transform.up * jumpPower);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            ground = true;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            ground = false;
        }
    }
}