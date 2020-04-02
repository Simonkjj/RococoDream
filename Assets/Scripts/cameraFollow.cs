using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    private Vector3 m_speed;

    void LateUpdate()
    {
        Vector3 desiredPos = target.position + offset;
        Vector3 smoothPos = Vector3.SmoothDamp(transform.position, desiredPos, ref m_speed, smoothSpeed);
        transform.position = smoothPos;
    }
}
