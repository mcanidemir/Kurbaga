using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Weapon_Select : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Weapon1;//fist
    public GameObject Weapon2;//lightsaber
    public GameObject Weapon3;//projectile
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
        if (true)
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
        if (true)
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
}
