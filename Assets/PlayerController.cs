using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;


    private float movementX;
    private float movementY;
    private Vector3 rotationAngle;

    void OnMove(InputValue movementValue)
    {
        Vector3 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void OnAnimatorIK(int layerIndex)
    {
        
    }
    void OnRotateRight(InputValue rotationValue)
    {
        rotationAngle = new Vector3(0, 1, 0);
    }

    void OnRotateLeft(InputValue rotationValue)
    {
        rotationAngle =  new Vector3(0, -1, 0);
    }

    void OnRotateStop(InputValue rotationValue)
    {
        rotationAngle = new Vector3(0, 0, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void FixedUpdate()
    {
        transform.eulerAngles += rotationAngle;
    }
}