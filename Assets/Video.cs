using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video : MonoBehaviour {

    [SerializeField]
    GameObject Player;

    private float time;

    Vector3 lavaPos = new Vector3(0, -35.44048f + 3.444882f, 0);
    Vector3 icePos = new Vector3(0, -42.48489f + 35.44048f, 0);
    bool lava = false;
    bool ice = false;

    // Update is called once per frame
    void Update () {
        time += Time.deltaTime;
        if(time > 7.5f && !ice)
        {
            Player.GetComponent<SimplePlayerController>().Attack();
        }
        if(time >8f && !lava)
        {
            lava = true;
            time = 0f;
            Player.transform.position = Player.transform.position + lavaPos;
        }
        if (time > 8f && lava && !ice)
        {
            
            ice = true;
            time = 0f;
            Player.transform.position = Player.transform.position + icePos;
        }
    }
}
