using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockLogic : MonoBehaviour {
	//private ParticleSystem destroyParticleEffect;
	//private GameObject particlesObject;
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
		//particlesObject = transform.GetChild(0).gameObject;
		transform.GetChild(0).SetParent(null);
		//Destroy (particlesObject, 2f);
		Destroy(gameObject);
	}
}
