using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideTrigger : MonoBehaviour
{
    public GameObject SlideParticle;
    public GameObject player;
    public GameObject touchCube;
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
            Instantiate(SlideParticle, transform.position, Quaternion.identity);
            player.GetComponent<PlayerScript>().Slide();
            Debug.Log("Slide");

        }
    }
}
