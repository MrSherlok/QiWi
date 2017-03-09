using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_attack : MonoBehaviour {
	public GameObject bur;
	public Animator ani;
	public void Attack () {
		ani.SetTrigger("Attack");
		//StartCoroutine("AttackActivate");

	}
	//public IEnumerator AttackActivate(){
	//	bur.GetComponent<BurMachine> ().attackNow = true;
	//	yield return new WaitForSeconds(0.5f);
	//	bur.GetComponent<BurMachine> ().attackNow = false;
	//}
}
