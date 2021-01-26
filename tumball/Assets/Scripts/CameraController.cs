using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform lookAt;


    private Vector3 desiredPosition;
    private Vector3 offset;

    private Vector2 touchPosition;

    private float smoothSpeed = 7.5f;
    private float distance = 10.0f;
    private float yOffset = 6.0f;


    private void Start()
    {
        offset = new Vector3(0, yOffset, -1f * distance);

    }
    public void left()
    {
        SlideCamera(false);
    }
    public void right()
    {
        SlideCamera(true);
    }

    private void Update()
    {  
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            SlideCamera(true);
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            SlideCamera(false);

        /*//when mouse button is pressed
        if(Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            touchPosition = Input.mousePosition;

        }

        //when mouse button is released
        if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
        {
            float swipeForce = touchPosition.x - Input.mousePosition.x;

            if (Mathf.Abs(swipeForce) > swipeResitance)
            {
                if (swipeForce < 0)
                    SlideCamera(true);
                else
                    SlideCamera(false);
            }

        } */

    }

    private void FixedUpdate()
    {
        desiredPosition = lookAt.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.LookAt(lookAt.position + Vector3.up);
    }

    public void SlideCamera(bool left)
    {
        if (left)
            offset = Quaternion.Euler(0, 90, 0) * offset;
        else
            offset = Quaternion.Euler(0, -90, 0) * offset;
    }
}
