using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurMachine : MonoBehaviour {
	private bool burCD = true;
	private ParticleSystem burEffect;
	public float burSpeed = 0.1f;
    private float burFirstSpeed = 0.3f;
    private bool count = false;

    public GameObject blockTargerSquad;

    public bool attackNow = false;


	void OnTriggerStay2D(Collider2D col){
		
		if (col.gameObject.tag == "DestroybleBox" && burCD && attackNow) {

            blockTargerSquad.transform.position = col.transform.position;


            burCD = false;
            //}
            //if(col.gameObject.tag == "DestroybleBox" && burCD)
            //{
            col.gameObject.GetComponent<BlockLogic>().GetDamage(1);
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

	}
}
