using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    public TextMeshProUGUI touchText;
    public Transform mainObject;

    private const int CAMERA_MOVEMENT = 10;
    private const float DIR_THRESHOLD = .80f;

    private Vector2 startingPosition;

    void Update()
    {
        //Example 1
        //phasesExample();

        //Example 2
        moveMainObject();

        //Example 3
        //verifyMovement();
    }

    void phasesExample()
    {
        Debug.Log(Input.touchCount);

        if (Input.touchCount > 0)
        {
            Touch input = Input.GetTouch(0);

            switch (input.phase)
            {
                case TouchPhase.Began:
                    touchText.text = Input.touchCount.ToString() + " Began";
                    break;
                case TouchPhase.Stationary:
                    touchText.text = Input.touchCount.ToString() + " Stationary";
                    break;
                case TouchPhase.Moved:
                    touchText.text = Input.touchCount.ToString() + " Moved";
                    break;
                case TouchPhase.Ended:
                    touchText.text = Input.touchCount.ToString() + " Ended";
                    break;
                case TouchPhase.Canceled:
                    touchText.text = Input.touchCount.ToString() + " Canceled";
                    break;
            }
        }
    }

    void moveMainObject()
    {
        if(Input.touchCount > 0)
        {
            Touch input = Input.GetTouch(0);

            if(input.phase == TouchPhase.Moved)
            {
                Debug.Log(Camera.main.ScreenToWorldPoint(new Vector3(input.position.x, input.position.y, CAMERA_MOVEMENT)));
                mainObject.position = Camera.main.ScreenToWorldPoint(new Vector3(input.position.x, input.position.y, CAMERA_MOVEMENT));
            }
        }
    }

    void verifyMovement()
    {
        if (Input.touchCount > 0)
        {
            Touch input = Input.GetTouch(0);

            switch (input.phase)
            {
                case TouchPhase.Began:
                    startingPosition = input.position;
                    break;
                case TouchPhase.Ended:
                    setDirection((input.position - startingPosition).normalized);
                    break;
            }
        }
    }

    void setDirection(Vector2 v2)
    {
        if (v2.x < -DIR_THRESHOLD)
        {
            touchText.text = "LEFT";
            PlayerValues.rotationDirection = Vector3.up;
        }
        else if (v2.y < -DIR_THRESHOLD)
        {
            touchText.text = "DOWN";
            PlayerValues.rotationDirection = Vector3.back;
        }
        else if (v2.x > DIR_THRESHOLD)
        {
            touchText.text = "RIGHT";
            PlayerValues.rotationDirection = Vector3.down;
        }
        else if (v2.y > DIR_THRESHOLD)
        {
            touchText.text = "UP";
            PlayerValues.rotationDirection = Vector3.forward;
        }
    }
}
