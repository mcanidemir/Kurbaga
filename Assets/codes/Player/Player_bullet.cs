using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player_bullet : MonoBehaviour
{
    public GameObject bullet;
    public GameObject spawnpoint;
    private Vector3 spawnpoint_location;
    private float timer = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnpoint_location = spawnpoint.transform.position;
        timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            player_bullet();
        }
    }
    public void player_bullet()
    {
        if (timer > 1.5)
        {
        Instantiate(bullet, spawnpoint_location, Quaternion.identity);
            timer = 0;
        }
    }
}
