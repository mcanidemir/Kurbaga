using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float speed;
    public float jump;
    private bool double_jump=false;
    public GameObject gun;
    private float direction;

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
       

        if (Input.GetKey(KeyCode.A))
        {
        transform.rotation = Quaternion.Euler(0, 180, 0);
            
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        //0.36 -0.92
        if (gun.transform.rotation.z >=-0.92 && gun.transform.rotation.z <= 0.36)
        {

            transform.rotation = Quaternion.Euler(0, 0, 0);



        }
        else 
        {

            transform.rotation = Quaternion.Euler(0, 180, 0);


        }
        Debug.Log(gun.transform.rotation.z);
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
