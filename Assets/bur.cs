using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class bur : MonoBehaviour
{
    //public VirtualJoystick left;

    private Transform _mainCameraTransform;
    private Transform _transform;

    private void OnEnable()
    {
        _mainCameraTransform = Camera.main.GetComponent<Transform>();
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
            //movementVector = _mainCameraTransform.TransformDirection(inputVector);
            //movementVector.y = 0f;
            //movementVector.Normalize();
            //_transform.forward = movementVector;
            var angle = Mathf.Acos((inputVector.x*-2+inputVector.y*0) / (Mathf.Sqrt((inputVector.x*inputVector.x)+(inputVector.y*inputVector.y))+Mathf.Sqrt(4)));
            Debug.Log(angle);
        }
        

        movementVector += Physics.gravity;


    }
}
