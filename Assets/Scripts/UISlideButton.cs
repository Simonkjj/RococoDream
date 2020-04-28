using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(RectTransform))]
public class UISlideButton : MonoBehaviour, IPointerDownHandler
{
    public PlayerScript playerScr;
    private bool dragging;
    private RectTransform myRect;
    private Canvas myCanvas;
    private Vector3 startPos, rSpeed;
    [SerializeField]
    private float maxDragDist;

    public bool isJumping = false;
    public bool isSliding = false;

    private void Awake()
    {
        myRect = GetComponent<RectTransform>();
        myCanvas = transform.GetComponentInParent<Canvas>();
        startPos = myRect.anchoredPosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        dragging = true;
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }

        if (dragging)
        {
            Vector3 nextPos = Input.mousePosition / myCanvas.scaleFactor;
            nextPos.x = startPos.x;
            nextPos.y = Mathf.Clamp(nextPos.y, startPos.y - maxDragDist, startPos.y + maxDragDist);
            myRect.anchoredPosition = nextPos;
        }
        else
        {
            myRect.anchoredPosition = Vector3.SmoothDamp(myRect.anchoredPosition, startPos, ref rSpeed, 0.1f);
        }

        //Debug.Log(Value());
        //FIX THIS
        //FIX THIS
        //FIX THIS

        if (Value() > 0.95f)
        {
            isJumping = true;
        }

        if (isJumping)
        {
            playerScr.Jump();
            isJumping = false;
        }

        if (Value() < -0.95f)
        {
            isSliding = true;
        }
            playerScr.SlideButton();
    }

    public float Value()
    {
        return ((myRect.anchoredPosition.y - startPos.y) / maxDragDist);
    }
}
