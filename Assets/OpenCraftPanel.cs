using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCraftPanel : MonoBehaviour {

	public GameObject craftPanel;
	private bool panelOpened;
	public void SwitchCraftPanel(){
		panelOpened = !panelOpened;
		if (panelOpened) {
			craftPanel.SetActive (true);
		} else {
			craftPanel.SetActive (false);
		}
	}
}
