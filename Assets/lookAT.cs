using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAT : MonoBehaviour {

    public Transform Stick;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Stick != null)
        {
            transform.LookAt(Stick);
        }
	}
}
