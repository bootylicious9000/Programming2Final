using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int Health = 5;
    public float JumpForce = 10f;
    public float JumpMult = 1f;
    public float JumpTime;
    public float JumpStart;
    public bool IsGrounded;
    public bool IsJumping;
    public LayerMask Ground;

    private Rigidbody2D rb; 

    public MovementState state;
    public enum MovementState
    {
        Grounded,
        Jumping
    }


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        StateMachiene();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && IsGrounded == true)
        {
            IsJumping = true;
            JumpTime = JumpStart;
            rb.AddForce(new Vector2(rb.velocity.x, JumpForce));
            IsGrounded = false;

        }

        if(IsJumping == true)
        {
            if(JumpTime > 0)
            {
                rb.AddForce(new Vector2(rb.velocity.x, JumpMult));
                JumpTime -= Time.deltaTime;
            }
            else
            {
                IsJumping = false;
            }
        }

        if(Input.GetButtonUp("Jump"))
        {
            IsJumping = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.contacts[0].normal.y > 0.5f)
        {
            IsGrounded = true;
            IsJumping = false;
        }

        if(collision.gameObject.layer == 8)
        {
            Debug.Log("GAME OVER");
            //KILL PLAYER!!!
        }
    }

    private void StateMachiene()
    {
        if(IsGrounded == true)
        {
            state = MovementState.Grounded;
            Debug.Log("Grounded");
        }

        else if(IsJumping == true)
        {
            state = MovementState.Jumping;
            Debug.Log("Jumping");
        }

    }

}
