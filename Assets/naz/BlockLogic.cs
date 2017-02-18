using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockLogic : MonoBehaviour {
	//private ParticleSystem destroyParticleEffect;
	public int hp = 3;
	void Start () {
		//destroyParticleEffect = GetComponentInChildren<ParticleSystem>();
	}

	public void GetDamage (int damage) {
		hp -= damage;
		//destroyParticleEffect.Play ();
		UpdateHp ();
	}
	private void UpdateHp(){
		
		if (hp <= 0) {
			Invoke("DestroyBlock",1f);
		}
	}
	private void DestroyBlock (){
		GetComponent<SpriteRenderer> ().enabled = false;
		Destroy(gameObject);
	}
}
