using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    [SerializeField]
    GameObject buttons;
    [SerializeField]
    GameObject joystick;

    public bool isPause = false;



    public void PauseButton()
    {
        isPause = !isPause;
        if (isPause)
        {
            Time.timeScale = 0f;
            buttons.SetActive(true);
            joystick.SetActive(false);
        }
        else
        {
            Time.timeScale = 1f;
            buttons.SetActive(false);
            joystick.SetActive(true);
        }
    }
}
