using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public float currHealth;
    public float MaxHealth = 3;
    public float loseHealth = 1;


    void Start()
    {
        currHealth = MaxHealth;
    }

    void Update()
    {
        GetComponent<Image>().fillAmount = currHealth;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsHit();
        }

        if (currHealth < 0.01f)
        {
            YouLose();
        }
    }

    public void IsHit()
    {
        //Debug.Log("Lose health");
        currHealth -= loseHealth;
    }

    void YouLose()
    {
        Respawn();
    }

    void Respawn()
    {
        currHealth = MaxHealth;
    }
}
