using UnityEngine;

public class Portal : MonoBehaviour {

    GameObject _player;


    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter2D(Collider2D col)
    {        
        if (col.gameObject.tag == "Player")
        {           
            _player.GetComponent<SimplePlayerController>().Respawn(0);
        }
    }

}
