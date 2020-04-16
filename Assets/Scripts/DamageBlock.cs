using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBlock : MonoBehaviour
{
    //flash red screen
    //push player back
    //destroy block
    //sound effects
    //screen shake

    public GameObject redFlash;
    private GameObject player;
    private Rigidbody2D rb;
    private AudioSource smashSE;


    [Range(1, 3)]
    public float pushForce;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = player.GetComponent<Rigidbody2D>();
        smashSE = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == ("Player"))
        {
            rb.velocity += new Vector2(-pushForce, 0);
            redFlash.SetActive(true);
            smashSE.Play();
            Destroy(gameObject);
        }
    }
}
