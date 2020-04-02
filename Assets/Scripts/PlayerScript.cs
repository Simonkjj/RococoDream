﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    public float speed = 20f;
    public float jumpForce = 10f;
    
    [SerializeField]
    public float scaleValue = .2f;
    public float slideTime = 1f;
    public float shrinkTime = 0.005f;

    [SerializeField]
    private bool isRunning = false;
    private bool isGrounded = false;
    private bool canSlide = false;

    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    public Button slideButton;
    public Button jumpButton;
    public Button runButton;
    public Button stopButton;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        slideButton = GameObject.FindGameObjectWithTag("SlideButton").GetComponent<Button>();
        jumpButton = GameObject.FindGameObjectWithTag("JumpButton").GetComponent<Button>();
        runButton = GameObject.FindGameObjectWithTag("RunButton").GetComponent<Button>();
        stopButton = GameObject.FindGameObjectWithTag("StopButton").GetComponent<Button>();
    }

    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void FixedUpdate()
    {
        if (isRunning)
        {
            rb.velocity = new Vector2(speed * 0.02f, rb.velocity.y);
            canSlide = true;
            jumpButton.interactable = true;
            slideButton.interactable = true;
            stopButton.interactable = true;
            runButton.interactable = false;
        } else
        {
            jumpButton.interactable = false;
            slideButton.interactable = false;
            stopButton.interactable = false;
            runButton.interactable = true;
        }

        if (isGrounded)
        {
            jumpButton.interactable = true;
        }
        else
        {
            jumpButton.interactable = false;
            runButton.interactable = false;
        }
    }

    public void Run()
    {
        if (isGrounded)
        {
            isRunning = true;
        }
    }

    public void Jump()
    {
        if (isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce * Time.deltaTime);
            isGrounded = false;
        }
    }

    public void SlideButton()
    {
        StartCoroutine(Slide());
    }

    public IEnumerator Slide()
    {
        if (isRunning)
        {
            canSlide = false;
            float defaultScale = transform.localScale.y;
            while (transform.localScale.y > defaultScale / 2)
            {
                transform.localScale -= new Vector3(0, scaleValue, 0);
                yield return new WaitForSeconds(shrinkTime);
            }

            yield return new WaitForSeconds(slideTime);

            while (transform.localScale.y < defaultScale)
            {
                transform.localScale += new Vector3(0, scaleValue, 0);
                yield return new WaitForSeconds(shrinkTime);
            }

            canSlide = true;
            yield return null;
        }
        yield return null;
    }

    public void Stop()
    {
        isRunning = false;
        rb.velocity = new Vector2(0, rb.velocity.y);
    }
}

