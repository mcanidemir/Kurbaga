using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    public float bulletdistance;

    private float timer;
    private GameObject player;
    private bool hasLineOfSight;
    public Animator animator;
    public GameObject shooting_spider;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        

        float distance = Vector2.Distance(transform.position, player.transform.position); 
        //Debug.Log(distance);

        if (hasLineOfSight)
        {
            if (distance < bulletdistance)
            {
                timer += Time.deltaTime;


                if (timer > 1.05)
                {
                 timer = 0;
                 shoot();
                }
                 animator.SetBool("shooting", true);
                shooting_spider.SetActive(true);
            }
            else
            {

                animator.SetBool("shooting", false);
                shooting_spider.SetActive(false);
            }
        }
        else
        {

            animator.SetBool("shooting", false);
                shooting_spider.SetActive(false);
        }

    }

    private void FixedUpdate()
    {
        RaycastHit2D[] ray = Physics2D.RaycastAll(transform.position, player.transform.position - transform.position);
        for(int i = 0; i<ray.Length; i++)
        {

        if (ray[i].collider != null)
        {
            hasLineOfSight = ray[i].collider.CompareTag("Player");
            if (hasLineOfSight)
            {
                Debug.DrawRay(transform.position, player.transform.position - transform.position, Color.green);
            }
            else
            {
                Debug.DrawRay(transform.position, player.transform.position - transform.position, Color.red);
            }
        }
        }
    }


    void shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
