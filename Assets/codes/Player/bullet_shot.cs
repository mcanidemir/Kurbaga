using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_shot : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed as needed
    private GameObject gun;
    private float timer;

    public GameObject bullet;

    private void Start()
    {
        Rigidbody2D rb2D = GetComponent<Rigidbody2D>();
       Vector2 velocity = new Vector2(1, 1) * speed;
        gun = GameObject.FindWithTag("Gun");
        float gunRotation = gun.transform.rotation.eulerAngles.z;    
        transform.rotation = Quaternion.Euler(0, 0, gunRotation+45);      
        rb2D.velocity = transform.right*velocity;
        transform.rotation = Quaternion.Euler(0, 0, gunRotation+45);      
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            Destroy(bullet);
        }
    }

}

