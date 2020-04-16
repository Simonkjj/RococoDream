using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunTrigger : MonoBehaviour
{
    public GameObject JumpParticle;
    public GameObject player;
    public Transform touchCube;
    public float cubeSPos;
    public Vector3 cubeTP;

    public void Start()
    {
        cubeSPos = touchCube.GetComponent<TouchSlider>().startPos.y;
        cubeTP = touchCube.transform.position;
    }

    public void Update()
    {
        transform.position = new Vector3(cubeTP.x, cubeSPos - 3, cubeTP.z);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ("TouchCube"))
        {
            Instantiate(JumpParticle, transform.position, Quaternion.identity);
            player.GetComponent<PlayerScript>().Jump();
            Debug.Log("Jump");
        }
    }
}
