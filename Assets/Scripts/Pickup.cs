using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    public GameObject Collectible;
    public GameObject History;




    // Start is called before the first frame update
    private void Start()
    {
        History.SetActive(false);

    }


    //private void OnMouseDown()
    //{
    //    if (Input.touchCount > 0)
    //        History.SetActive(true);

    //    Destroy(History, 5);



    //}
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            print("Touch Screen : " + Input.GetTouch(0).position);
            Vector3 Pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            print("Pos " + Pos);

            if (Input.touchCount > 0)
                History.SetActive(true);

            Destroy(History, 5);


        }











    }
}
