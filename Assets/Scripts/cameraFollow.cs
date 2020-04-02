using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.2f;
    public Vector3 offset;
    private Vector3 m_speed, desiredPos;


	void LateUpdate()
	{
		desiredPos = target.position + offset;
		transform.position = Vector3.SmoothDamp(transform.position, desiredPos, ref m_speed, smoothSpeed);
	}
}
