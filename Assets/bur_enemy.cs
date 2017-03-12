using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bur_enemy : MonoBehaviour
{

    private bool burCD = true;
    public float burSpeed = 0.1f;

    private bool hasBlock = false;


    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "DestroybleBox" && burCD)
        {
            hasBlock = true;
            burCD = false;
            col.gameObject.GetComponent<BlockLogic>().GetDamage(1);
            StartCoroutine("BurCD");
        }

    }

    IEnumerator BurCD()
    {

        yield return new WaitForSeconds(burSpeed);
        burCD = true;

    }
}