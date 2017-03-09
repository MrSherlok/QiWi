using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurMachine : MonoBehaviour {
	private bool burCD = true;
	private ParticleSystem burEffect;
	public float burSpeed = 0.1f;
    private float burFirstSpeed = 0.3f;
    private bool count = false;

    public static bool hasBlock = false;

    //public GameObject bur;
    public Animator ani;

    public GameObject blockTargerSquad;

    //public bool attackNow = true;


	void OnTriggerStay2D(Collider2D col){
		
		if (col.gameObject.tag == "DestroybleBox" && burCD) {
            hasBlock = true;
            blockTargerSquad.transform.position = col.transform.position;
            Attack();
            burCD = false;
            //}
            //if(col.gameObject.tag == "DestroybleBox" && burCD)
            //{
            col.gameObject.GetComponent<BlockLogic>().GetDamage(1);
            StartCoroutine("BurCD");
        } else
        {
            hasBlock = false;
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



    public void Attack()
    {
        ani.SetTrigger("Attack");
        //StartCoroutine("AttackActivate");

    }
    //public IEnumerator AttackActivate()
    //{
    //    gameObject.GetComponent<BurMachine>().attackNow = true;
    //    yield return new WaitForSeconds(0.4f);
    //    gameObject.GetComponent<BurMachine>().attackNow = false;
    //}
}
