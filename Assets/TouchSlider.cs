using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSlider : MonoBehaviour
{
    bool isClicked;
    private Vector3 cMousePos;
    public Vector3 startPos;
    public float returnSpeed = 7f;

    public float startXPos;

    public Transform player;



    public void Update()
    {
        startPos = new Vector3 (player.position.x - 3.5f, 0, 0);

        var cubePos = transform.position;
        cubePos.x = Mathf.Clamp(player.position.x - 3.5f, startXPos, startXPos);
        cubePos.y = Mathf.Clamp(cubePos.y, -3, 3);
        transform.position = cubePos;

        cMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log(cMousePos);

        if (!isClicked)
        {
            transform.position = Vector3.Lerp(transform.position, startPos, returnSpeed * Time.deltaTime);
        }
    }

    private void OnMouseDrag()
    {
        transform.position = cMousePos += new Vector3 (0,0,2);
        isClicked = true;
    }

    private void OnMouseUp()
    {
        isClicked = false;
    }
}
