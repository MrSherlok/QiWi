using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombScript : MonoBehaviour {

	public float time = 100f;
	public Image timerUI;
	public GameObject destroyColliders;
	SpriteRenderer bombSprite;
	public ParticleSystem fire;
	void Start () {
		bombSprite = GetComponent<SpriteRenderer>();
		StartCoroutine("Boom");
	}

	IEnumerator Boom(){
		for (float i = 100; i > time;i--) {
			
			timerUI.fillAmount = i/100;
			yield return new WaitForSeconds (0.01f);
			yield return null;
		}
		timerUI.fillAmount = 0;
		fire.Stop ();
		DestroyBox ();
	}
	void DestroyBox(){
		bombSprite.enabled = false;
		destroyColliders.SetActive(true);
	}
}
