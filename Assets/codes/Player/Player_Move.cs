using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float speed;
    public float jump;
    private bool double_jump=false;
    public GameObject gun;
    public GameObject arm;
    public Animator Player_;

    private float Move;

    public Rigidbody2D rb;

    public bool isJumping;

    //public Animator animator;
    private void Start()
    {

    }

    private void Update()
    {
        if (!arm.activeSelf)
        {
            Player_.SetBool("has_arm", true);
        }
        else
        {
            Player_.SetBool("has_arm", false);
        }

        Move = Input.GetAxis("Horizontal");

        //animator.SetFloat("Speed", Mathf.Abs(Move));
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            if (double_jump && isJumping)
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(rb.velocity.x, jump));
                double_jump = false;
            }
            else if (!isJumping)
            {
                rb.AddForce(new Vector2(rb.velocity.x, jump));
                isJumping = true;
            }
        }
       


        //
        if (gun.transform.rotation.z >=-0.94 && gun.transform.rotation.z <= 0.36)
        {
            if (gun.transform.rotation.z != 0)
            {
            transform.rotation = Quaternion.Euler(0, 0, 0);
               // Debug.Log("b");

            }
        }
        else 
        {
            if (gun.transform.rotation.z!=0)
            {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            //Debug.Log("a");

            }
            //Debug.Log(gun.transform.rotation.z);
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
            double_jump = true;
        }
    }
}
