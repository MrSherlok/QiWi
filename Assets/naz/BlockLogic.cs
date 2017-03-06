using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockLogic : MonoBehaviour {
    //public int PosX;
    //public int PosY;
	private ParticleSystem destroyParticleEffect;
	private GameObject particlesObject;
	public int hp = 3;
	void Start () {
		//destroyParticleEffect = GetComponentInChildren<ParticleSystem>();
        //gameObject.GetComponent<SpriteRenderer>().color = new Color(0,0,0,255);

    }

	public void GetDamage (int damage) {
		hp -= damage;
		//destroyParticleEffect.Play ();
		UpdateHp ();
	}
	private void UpdateHp(){
		
		if (hp <= 0) {
			Invoke("DestroyBlock",0f);
		}
	}
	private void DestroyBlock (){
	//	particlesObject = transform.GetChild(0).gameObject;
		//transform.GetChild(0).SetParent(null);
		//Destroy (particlesObject, 2f);
		Destroy(gameObject);
	}
}
