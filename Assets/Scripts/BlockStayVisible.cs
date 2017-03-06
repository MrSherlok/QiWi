using UnityEngine;
using System.Collections;
using System.IO;

public class BlockStayVisible : MonoBehaviour {

    [SerializeField]
    GameObject Player;

    private GameObject _tile;


    private void Update()
    {
        gameObject.transform.position = Player.transform.position;
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(col.gameObject.name);
        if (col.gameObject.GetComponent<BlockLogic>() != null)
        {
            _tile = col.gameObject;
            //string[] pos = gameObject.name.Split('_');
            UpdateWorld();
            //UpdateWorld(col.gameObject.GetComponent<BlockLogic>().PosX, col.gameObject.GetComponent<BlockLogic>().PosY);
        }
    }

    private void UpdateWorld(/*int _posX, int _posY*/)
    {
        //char[] mapVisible = ReadLevelVisible();

        //int maxX = mapVisible.Length;

        //int place = _posY * 101 + _posX;
        //mapVisible[place] = '1';

        //string txtFull = "";

        //for (int x = 0; x < maxX; x++)
        //    txtFull += mapVisible[x].ToString();

        _tile.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);



    }

    //private char[] ReadLevelVisible()
    //{
    //    TextAsset bindData = Resources.Load("visible") as TextAsset;

    //    //string data = bindData.text.Replace(System.Environment.NewLine, string.Empty);
    //    return bindData.text.ToCharArray();
    //}
}
