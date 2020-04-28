using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    [Range(0,3)]
    public int currHealth;
    public int MaxHealth = 3;
    public int loseHealth = 1;

    public Sprite zero;
    public Sprite one;
    public Sprite two;
    public Sprite three;

    private Image h_img;

    void Start()
    {
        h_img = GetComponent<Image>();
        currHealth = MaxHealth;
        loseHealth = 1;
    }

    void Update()
    {
        if (currHealth < 0.01f)
        {
            h_img.sprite = zero;
            YouLose();
        }
        if(currHealth > .5f && currHealth < 1.5f)
        {
            h_img.sprite = one;
        }
        if (currHealth > 1.5f && currHealth < 2.5f)
        {
            h_img.sprite = two;
        }
        if (currHealth > 2.5f)
        {
            h_img.sprite = three;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsHit();
        }

    }

    public void IsHit()
    {
        currHealth = currHealth - loseHealth;
    }

    void YouLose()
    {
        Respawn();
    }

    void Respawn()
    {
        //currHealth = MaxHealth;
    }
}
