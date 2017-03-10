using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockLogic : MonoBehaviour {
    //public int PosX;
    //public int PosY;
    public bool newBlock = false;

    [SerializeField]
    private GameObject _backLayer;

    [SerializeField]
    private GameObject _midLayer;

    [SerializeField]
    private GameObject _frontLayer;




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
        if (newBlock)
        {
            if (hp == 3)
            {
                _backLayer.SetActive(true);
                _midLayer.SetActive(true);
                _frontLayer.SetActive(true);
            }
            if (hp == 2)
            {
                _backLayer.SetActive(true);
                _midLayer.SetActive(true);
                _frontLayer.SetActive(false);
            }
            if (hp == 1)
            {
                _backLayer.SetActive(true);
                _midLayer.SetActive(false);
                _frontLayer.SetActive(false);
            }
        }
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
