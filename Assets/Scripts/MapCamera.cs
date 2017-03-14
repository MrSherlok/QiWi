using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCamera : MonoBehaviour {

    [SerializeField]
    Camera main;
    [SerializeField]
    GameObject bag;
    [SerializeField]
    GameObject craftPanel;

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
            bag.SetActive(true);
            main.orthographicSize = 2;
            //main.enabled = true;
            //map.enabled = false;
        } else
        {
            bag.SetActive(false);
            craftPanel.SetActive(false);
            main.orthographicSize = 10;
            //main.enabled = false;
            //map.enabled = true;
        }
    }
}
