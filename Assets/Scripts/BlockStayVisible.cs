using UnityEngine;
using System.Collections;
using System.IO;

public class BlockStayVisible : MonoBehaviour {

    [SerializeField]
    GameObject Player;

    [SerializeField]
    private Level_blocks _visibleScript;

    private GameObject _tile;


    private void Update()
    {
        gameObject.transform.position = Player.transform.position;
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(col.gameObject.name);
        if (col.gameObject.tag == "DestroybleBox" || col.gameObject.tag == "UndestroybleBox")
        {
            _tile = col.gameObject;
            //string[] pos = gameObject.name.Split('_');
            ChangeColor(_tile);
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
        //ChangeColor(_tile);

        //_tile.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);



    }


    private void ChangeColor(GameObject block)
    {
        //int children = block.transform.childCount;
        //for (int i = 0; i < children; ++i)
        //{
        //    if (block.transform.GetChild(i) != null)
        //    {
                block.GetComponent<SpriteRenderer>().enabled = false;
        //    }
        //}
    }

    //private char[] ReadLevelVisible()
    //{
    //    TextAsset bindData = Resources.Load("visible") as TextAsset;

    //    //string data = bindData.text.Replace(System.Environment.NewLine, string.Empty);
    //    return bindData.text.ToCharArray();
    //}
}
