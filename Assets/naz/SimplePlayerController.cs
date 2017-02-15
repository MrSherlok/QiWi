using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerController : MonoBehaviour {
	public float speed;             
	private Rigidbody2D rb2d;      

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate()
	{

		float moveHorizontal = Input.GetAxis ("Horizontal");

		rb2d.velocity = new Vector2 (moveHorizontal, rb2d.velocity.y);
		if (moveHorizontal < 0.5f) {
			transform.rotation = Quaternion.Euler (0, 0, 0);
		} else if (moveHorizontal > 0.5f) {
			transform.rotation = Quaternion.Euler (0, 180, 0);
		}
		if (Input.GetKeyDown("space")){
			rb2d.velocity = Vector2.up * 100 * Time.deltaTime;
		}
	}
}