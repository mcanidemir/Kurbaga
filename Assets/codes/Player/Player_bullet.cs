using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_bullet : MonoBehaviour
{
    public GameObject bullet;
    public GameObject spawnpoint;
    private Vector3 spawnpoint_location;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnpoint_location = spawnpoint.transform.position;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            player_bullet();
        }
    }
    public void player_bullet()
    {
        Instantiate(bullet, spawnpoint_location, Quaternion.identity);
    }
}
