using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCamera : MonoBehaviour {

    [SerializeField]
    Camera main;
    [SerializeField]
    Camera map;

    bool mainCam;

	void Start () {
        mainCam = true;
        main.enabled = true;
        map.enabled = false;
    }

    public void SwitchCam ()
    {
        mainCam = !mainCam;
        if (mainCam)
        {
            main.enabled = true;
            map.enabled = false;
        } else
        {
            main.enabled = false;
            map.enabled = true;
        }
    }
}
