using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject chatbox;
    public Animator Chatbox;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            chatbox.SetActive(true);
            Chatbox.SetBool("open", true);
            Chatbox.SetBool("close", false);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Chatbox.SetBool("close",true);
            Chatbox.SetBool("open",false);
            //chatbox.SetActive(false);
        }
    }
}
