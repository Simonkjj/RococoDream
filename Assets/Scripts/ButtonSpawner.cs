using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawner : MonoBehaviour
{
    public GameObject qteButton;
    public Transform target;
    public float shotSpeed;
    public Transform spawnFolder;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Shoot button");
            GameObject projectile = Instantiate(qteButton, transform.right, Quaternion.identity);
            //projectile.transform.position = Vector3.MoveTowards(projectile.transform.position, target.position, shotSpeed * Time.deltaTime);
            projectile.transform.SetParent(spawnFolder);
        }
    }
}
