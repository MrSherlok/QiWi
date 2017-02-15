﻿using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class VirtualJoystick : MonoBehaviour,IDragHandler,IPointerUpHandler,IPointerDownHandler {
    [SerializeField]
    private Image bgImage;
    [SerializeField]
    private Image joystickImg;
    private Vector3 inputVector;


    void Start()
    {
        bgImage = /*transform.GetChild(0).*/GetComponent<Image>();
        joystickImg = transform.GetChild(0).GetComponent<Image>();
    }

    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(bgImage.rectTransform,
                                                                    ped.position,
                                                                    ped.pressEventCamera,
                                                                    out pos))
        {
            pos.x = (pos.x/bgImage.rectTransform.sizeDelta.x);
            pos.y = (pos.y / bgImage.rectTransform.sizeDelta.y);

            inputVector = new Vector3(pos.x * 2 + 1, 0, pos.y * 2 - 1);
            inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;

            //Move img
            joystickImg.rectTransform.anchoredPosition = new Vector3(inputVector.x * (bgImage.rectTransform.sizeDelta.x / 3),
                                                                      inputVector.z * (bgImage.rectTransform.sizeDelta.y / 3));

        }
    }

    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }

    public virtual void OnPointerUp(PointerEventData ped)
    {
        inputVector = Vector3.zero;
        joystickImg.rectTransform.anchoredPosition = Vector3.zero;
    }

    public float Horizontal ()
    {
        if (inputVector.x != 0)
            return inputVector.x;
        else return Input.GetAxis("Horizontal");
    }

    public float Vertical()
    {
        if (inputVector.z != 0)
            return inputVector.z;
        else return Input.GetAxis("Vertical");

    }




    // Update is called once per frame
    void Update () {
		
	}
}
