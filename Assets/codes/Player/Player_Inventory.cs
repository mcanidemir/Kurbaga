using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Inventory : MonoBehaviour
{
    public GameObject Weapon1;//fist
    public GameObject Weapon2;//lightsaber
    public GameObject Weapon3;//projectile

    public bool has_Weapon2;
    public bool has_Weapon3;

    public GameObject weapon2_onFloor;
    public GameObject weapon3_onFloor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region weapon1
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Weapon1.SetActive(true);
            Weapon2.SetActive(false);
            Weapon3.SetActive(false);
        }
        #endregion

        #region weapon2
        if (has_Weapon2==true)
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Weapon1.SetActive(false);
                Weapon2.SetActive(true);
                Weapon3.SetActive(false);
            }
        }
        #endregion

        #region weapon3
        if (has_Weapon3 == true)
        {
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Weapon1.SetActive(false);
                Weapon2.SetActive(false);
                Weapon3.SetActive(true);
            }
        }
        #endregion


    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Weapon2"))
        {
            has_Weapon2 = true;
            Destroy(weapon2_onFloor);
        }

        if (other.gameObject.CompareTag("Weapon3"))
        {
            has_Weapon3 = true;
            Destroy(weapon3_onFloor);
        }
    }
}
