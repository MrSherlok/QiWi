using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurMachine : MonoBehaviour {
	private bool burCD = true;
	private ParticleSystem burEffect;
	private float burSpeed = 0.1f;
    private float burFirstSpeed = 0.3f;
    private bool count = false;


	void OnTriggerStay2D(Collider2D col){
		
		if (col.gameObject.tag == "DestroybleBox" && burCD/* && count*/) {
			Debug.Log("im collide");
			col.gameObject.GetComponent<BlockLogic>().GetDamage(1);
			burCD = false;
		//}
        //if(col.gameObject.tag == "DestroybleBox" && burCD)
        //{
            StartCoroutine("BurCD");
        }
	}
	IEnumerator BurCD(){
		//burEffect.Play();
        //if(count)
		yield return new WaitForSeconds (burSpeed);
        //count = true;
		burCD = true;
		//burEffect.Stop();
		Debug.Log("im ready");
	}
}
