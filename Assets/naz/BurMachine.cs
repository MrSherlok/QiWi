using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurMachine : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col){
		Debug.Log ("IGotIt");
		if (col.gameObject.tag == "DestroybleBox") {
			col.gameObject.GetComponent<BlockLogic>().GetDamage(1);
		}
	}
}
