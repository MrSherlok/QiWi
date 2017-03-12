using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    [SerializeField]
    GameObject Player;

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "fog")
        {
            transform.position = Vector3.Lerp(transform.position, Player.transform.position, 0.01f);
        }
    }
}
