using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlocks : MonoBehaviour {
	Collider2D goCollider;
	public GameObject globalBombOnject;
	void Start() {
		goCollider = GetComponent<Collider2D> ();
	}

	void OnTriggerStay2D(Collider2D col){

		if (col.gameObject.tag == "DestroybleBox") {

			col.gameObject.GetComponent<BlockLogic>().GetDamage(5);
			goCollider.enabled = false;
			Destroy(globalBombOnject,2f);

		}
	}
}
