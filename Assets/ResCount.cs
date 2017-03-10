using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResCount : MonoBehaviour {

	private int resources;
	Text text;
	void Start () {
		Text text = gameObject.GetComponent<Text>();
	}
	public void AddRes(int count){
		resources += count;
		RenewUI ();
	}
	private void RenewUI(){
		text.text = resources.ToString();
	}

}
