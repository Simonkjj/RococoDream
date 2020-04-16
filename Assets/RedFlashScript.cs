using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFlashScript : MonoBehaviour
{
    public bool isDamaged = false;
    [SerializeField]
    private float counter;
    public float flashTime = 1;

    private void Start()
    {
        isDamaged = false;
        gameObject.SetActive(false);
    }
    private void Update()
    {
        if (isDamaged)
        {
            counter += flashTime * Time.deltaTime;
        }

        if(counter > 1)
        {
            isDamaged = false;
            counter = 0;
        }

        if (counter > 0.01f)
        {
            gameObject.SetActive(true);

        } else
        {
            //gameObject.SetActive(false);
        }

    }
}
