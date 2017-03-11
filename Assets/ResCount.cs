using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResCount : MonoBehaviour {


    public static int gold = 0;
    public static int silver = 0;


	private int resources;
    [SerializeField]
    Text textG;
    [SerializeField]
    Text textS;
  //  void Start () {
		//Text textG = gameObject.GetComponent<Text>();
  //  }




    //   public void AddRes(int count){
    //	resources += count;
    //	RenewUI ();
    //}
    //private void RenewUI(){
    //	text.text = resources.ToString();
    //}


    void Update()
    {
        textG.text = gold.ToString();
        textS.text = silver.ToString();
    }
}
