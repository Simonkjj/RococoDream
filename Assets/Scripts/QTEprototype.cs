using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QTEprototype : MonoBehaviour
{
    public float startFillAmount = .99f;
    public float loseSpeed = 0.001f;
    public float pressFillAmount = 1f;
    private float timeThr = 0;

    public float shotSpeed = 5;
    public Transform target;

    private bool YouWin = false;
    public Color green;

    public GameObject blueExpl;
    public GameObject greenLight;
    public GameObject innerButton;

    public Transform folder;

    //void EnterCombat()
    //void ExitCombat()

    public void Start()
    {
        //GameObject target = GameObject.FindGameObjectWithTag("Player");
    }
    public void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, target.position, shotSpeed * Time.deltaTime);

        GetComponent<Image>().fillAmount = startFillAmount;
        timeThr += Time.deltaTime * 100;

        if (!YouWin)
        {
            if (timeThr > .5f)
            {
                timeThr = 0;
                startFillAmount -= loseSpeed;
            }
        }

        if (startFillAmount < 0 && !YouWin)
        {
            startFillAmount = 0;
            Debug.Log("You Lose");
        }
    }

    public void ButtonPressed()
    {
        startFillAmount += pressFillAmount;

        if (startFillAmount > 1)
        {
            YouWin = true;
            Debug.Log("You Win");
            startFillAmount = 1;

            GameObject expl = Instantiate(blueExpl, transform.position, Quaternion.identity);
            GameObject light = Instantiate(greenLight, transform.position, Quaternion.identity);


            expl.transform.SetParent(folder);
            expl.transform.SetSiblingIndex(1);
            light.transform.SetParent(folder);
            light.transform.SetSiblingIndex(0);

            Destroy(gameObject);
            Destroy(innerButton);
        }

    }

}
