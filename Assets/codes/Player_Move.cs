using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float speed;
    public float jump;
    private bool double_jump=false;

    private float Move;

    public Rigidbody2D rb;

    public bool isJumping;

    //public Animator animator;
    private void Start()
    {

    }

    private void Update()
    {
        Move = Input.GetAxis("Horizontal");

        //animator.SetFloat("Speed", Mathf.Abs(Move));
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            if (double_jump)
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(rb.velocity.x, jump));
                double_jump = false;
            }
            else if (!isJumping)
            {
                rb.AddForce(new Vector2(rb.velocity.x, jump));
                double_jump = true;
                isJumping = true;
            }
        }
       

        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = true;
        }
    }
}
