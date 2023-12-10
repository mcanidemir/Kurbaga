using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Tracker : MonoBehaviour
{
    private Transform m_transform;
    void Start()
    {
        m_transform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        LAMouse();
        Debug.Log(m_transform.position.x);
    }
    public void LAMouse()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - m_transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle - 45, Vector3.forward);
        m_transform.rotation = rotation;
    }
}
