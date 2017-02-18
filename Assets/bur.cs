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
            float a = Mathf.Sqrt((inputVector.x * inputVector.x)+ (inputVector.y * inputVector.y));
            float b = Mathf.Sqrt(1);
            float c = Mathf.Sqrt((inputVector.x+1)*(inputVector.x + 1) +(inputVector.y)*(inputVector.y));
            float angle = (a * a + b * b - c * c) / (2 * a * b);
            float ccos = (a * a + b * b - c * c) / (2 * a * b);
            //float ccos = Mathf.Cos(inputVector.x / c);
            float aangle = ccos / Mathf.PI * 180;
            float bur_angle = 360 * ccos;
            var angle1 = Mathf.Acos(Mathf.Cos((inputVector.x*1+inputVector.y*0) / (Mathf.Sqrt((inputVector.x*inputVector.x)+(inputVector.y*inputVector.y))+Mathf.Sqrt(1))));
            Debug.Log(ccos);
            Debug.Log("   "+bur_angle);
            Debug.Log("x= " + inputVector.x);
            Debug.Log("y= "+ inputVector.y);
            //Debug.Log("try= " + aangle);
        }
        

        movementVector += Physics.gravity;


    }
}
