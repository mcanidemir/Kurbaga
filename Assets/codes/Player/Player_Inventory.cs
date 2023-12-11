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
    public Animator anim;

    public GameObject weapon2_onFloor;
    public GameObject weapon3_onFloor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("a");
            anim.SetBool("attack", true);
        }
        else
        {
            anim.SetBool("attack", false);

        }
        #region weapon1
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            anim.SetBool("punch", true);
            anim.SetBool("melee", false);
            anim.SetBool("ranged", false);

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
                anim.SetBool("punch", false);
                anim.SetBool("melee", true);
                anim.SetBool("ranged", false);

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
                anim.SetBool("punch", false);
                anim.SetBool("melee", false);
                anim.SetBool("ranged", true);

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
