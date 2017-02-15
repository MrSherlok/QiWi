using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class bur : MonoBehaviour
{
    //public VirtualJoystick left;

    private Transform _mainCameraTransform;
    private Transform _transform;
    private CharacterController _characterController;

    private void OnEnable()
    {
        _mainCameraTransform = Camera.main.GetComponent<Transform>();
        _characterController = GetComponent<CharacterController>();
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 inputVector = new Vector3(CnInputManager.GetAxis("Horizontal"), CnInputManager.GetAxis("Vertical"));
        Vector3 movementVector = Vector3.zero;
       
        // If we have some input
        if (inputVector.sqrMagnitude > 0.001f)
        {
            movementVector = _mainCameraTransform.TransformDirection(inputVector);
            movementVector.y = 0f;
            movementVector.Normalize();
            _transform.forward = movementVector;
        }

        movementVector += Physics.gravity;
        _characterController.Move(movementVector * Time.deltaTime);


    }
}
