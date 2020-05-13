using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [Header("Enemys health")]
    public int health = 100;

    [Header("Enemys effect upon death")]
    public GameObject deatheffect;

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Instantiate(deatheffect, transform.position, Quaternion.identity);
    }
}
