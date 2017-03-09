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
        //main.enabled = true;
        //map.enabled = false;
    }

    public void SwitchCam ()
    {
        mainCam = !mainCam;
        if (mainCam)
        {
            main.orthographicSize = 2;
            //main.enabled = true;
            //map.enabled = false;
        } else
        {
            main.orthographicSize = 10;
            //main.enabled = false;
            //map.enabled = true;
        }
    }
}
