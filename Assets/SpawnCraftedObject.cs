using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCraftedObject : MonoBehaviour {

	public GameObject craftedObject;
	public GameObject target;
	public void Create () {
		GameObject newBlock = Instantiate (craftedObject);
		newBlock.transform.position = target.transform.position;

	}
}
