using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Chase : MonoBehaviour
{
    private GameObject player;
    public float speed;
    public float chasedistance;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
    player = GameObject.FindWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        if (distance < chasedistance)
        {
        Vector2 direction = player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

        }
    }
}
