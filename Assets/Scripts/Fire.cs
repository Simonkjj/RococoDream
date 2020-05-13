using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [Header("Define throw position")]
    [Tooltip("Empty gameobject attached to the player as a child object that will be the firepoint position")]
    public Transform firePoint;


    [Header("The damage you want to deal")]
    public int damage = 40;


    [Header("Effect on knife hit")]
    [Tooltip("Plays an effect when the knife hits something")]
    public GameObject impactEffect;

    [Tooltip("Make a line effect to add here")]
    public LineRenderer lineRenderer;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Shoot());
        }

    }

    
    IEnumerator Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);

        if (hitInfo)
        {
            EnemyHealth enemy = hitInfo.transform.GetComponent<EnemyHealth>();
            if (enemy != null){

                 
                enemy.TakeDamage(damage);
              Debug.Log(hitInfo.transform.name);
            }

            Instantiate(impactEffect, hitInfo.point, Quaternion.identity);

            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, hitInfo.point);
        }
        else
        {
            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, firePoint.position + firePoint.right * 100);
        }

        lineRenderer.enabled = true;

        yield return 0;

        lineRenderer.enabled = false;
    }

    
        
    
}
