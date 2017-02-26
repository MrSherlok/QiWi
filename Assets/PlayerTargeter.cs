using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTargeter : MonoBehaviour {

	void OnTriggerStay2D(Collider2D col){

		if (col.gameObject.tag == "Player") {
			Debug.Log("Im got Player now !");
			transform.parent.gameObject.transform.position = Vector3.Lerp (transform.position , col.transform.position, 0.01f);

		}

	}

}
