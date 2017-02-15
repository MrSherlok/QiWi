using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurMachine : MonoBehaviour {
	bool burCD = true;
	public ParticleSystem burEffect;
	public float burSpeed;

	void OnCollisionStay2D(Collision2D col){
		
		if (col.gameObject.tag == "DestroybleBox" && burCD) {
			Debug.Log("im collide");
			col.gameObject.GetComponent<BlockLogic>().GetDamage(1);
			burCD = false;
			StartCoroutine("BurCD");
		}
	}
	IEnumerator BurCD(){
		burEffect.Play();
		yield return new WaitForSeconds (burSpeed);
		burCD = true;
		burEffect.Stop();
		Debug.Log("im ready");
	}
}
