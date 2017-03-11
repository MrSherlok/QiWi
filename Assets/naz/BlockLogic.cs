using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockLogic : MonoBehaviour {
    //public int PosX;
    //public int PosY;
    public bool noneRes = true;
    public bool goldRes = false;
    public bool silverRes = false;

    //private GameObject resBase;

    [SerializeField]
    private GameObject _backLayer;

    [SerializeField]
    private GameObject _midLayer;

    [SerializeField]
    private GameObject _frontLayer;

    //void Start()
    //{
    //    resBase = GameObject.Find("CountRes");
    //}
 //   public GameObject destroyParticleEffect;
	//private GameObject particlesObject;
	public int hp = 3;


	public void GetDamage (int damage) {
		hp -= damage;
        
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
		UpdateHp ();
	}
	private void UpdateHp(){
		
		if (hp <= 0) {

            if (!noneRes)
            {
                if (goldRes)
                    ResCount.gold++;
                if (silverRes)
                    ResCount.silver++;
            }
			//if (destroyParticleEffect != null) {
			//	Debug.Log ("im Created");
			//	Instantiate (destroyParticleEffect,transform.position,Quaternion.identity);

			//	resBase.GetComponent<ResCount>().AddRes(1);
			//}
			Destroy(gameObject);
		}
	}

}
