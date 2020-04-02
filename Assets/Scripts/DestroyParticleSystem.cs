using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticleSystem : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 1.2f);
    }

    void Update()
    {
        transform.Rotate(0, 0, -50);
    }
}
