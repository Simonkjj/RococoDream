using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFlashScript : MonoBehaviour
{
    private float counter;
    public float flashTime;
    //public GameObject cam;
    //private Animator camAn;
    private void Start()
    {
        //camAn = cam.GetComponent<Animator>();
        //camAn.SetBool("shouldShake", true);
    }

    private void Update()
    {
        counter += Time.deltaTime;

        if(counter > flashTime)
        {
            //camAn.SetBool("shouldShake", false);
            counter = 0;
            gameObject.SetActive(false);
        }
    }
}
