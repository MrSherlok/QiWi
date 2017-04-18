using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    [SerializeField]
    private GameObject Player;
	Animator ani;
	public GameObject pivot;

    private void Start()
	{	ani = GetComponent<Animator> ();
        Player = GameObject.FindGameObjectWithTag("Player");
		ani.SetBool("ImFollow",false);
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "fog")
        {	
			if (transform.position.x > Player.transform.position.x) {
				transform.rotation = Quaternion.Euler (0, 0, 0);
			} else {
				transform.rotation = Quaternion.Euler(0, 180, 0);
			}
            transform.position = Vector3.Lerp(transform.position, Player.transform.position, 0.01f);
        }
    }
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "fog")
		{
			ani.SetBool("ImFollow",true);
		}
        if(col.gameObject.tag == "Player")
        {
            Player.GetComponent<SimplePlayerController>().Respawn(0);
        }
	}
	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.tag == "fog")
		{
			ani.SetBool("ImFollow",false);
		}
	}
}
