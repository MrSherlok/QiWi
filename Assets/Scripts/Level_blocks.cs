﻿using System;
using UnityEngine;
using UnityEngine.UI;

public class Level_blocks : MonoBehaviour
{


    [SerializeField]
    private GameObject[] blocksTypes;

    //public Text txt;


    public float blockSize
    {
        get { return blocksTypes[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x; }
    }
    // Use this for initialization
    void Start()
    {
        CreateLevel();
    }

    private void CreateLevel()
    {
        string[] mapData = ReadLevelText();
        string[] mapVisible = ReadLevelVisible();


        int mapX = mapData[0].ToCharArray().Length;

        int mapY = mapData.Length;

        Vector3 worldStart = new Vector3(0f, 0f, 0f)/*Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height/8))*/;

        for (int y = 0; y < mapY; y++)
        {
            //txt.text += y + "   ";
            char[] newBlock = mapData[y].ToCharArray();
            char[] blockVisible = mapVisible[y].ToCharArray();

            for (int x = 0; x < mapX; x++)
            {
                PlaceBlock(newBlock[x].ToString(), x, y, worldStart, blockVisible[x]);
                //txt.text += newBlock[x].ToString();
            }
            //txt.text += "\n";
        }
    }


    private void PlaceBlock(string blockType, int x, int y, Vector3 worldStart, char blockVis)
    {
        int blockIndex = int.Parse(blockType);

        if (blockIndex != 0)
        {
            GameObject newBlock = Instantiate(blocksTypes[blockIndex]);
            //newBlock.GetComponent<BlockLogic>().PosX = x;
            //newBlock.GetComponent<BlockLogic>().PosY = y;
            newBlock.name = x + "_" + y;
            if(blockVis == '0')
            {
                newBlock.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 255);
            }
            newBlock.transform.position = new Vector3(worldStart.x + (blockSize * x), worldStart.y - (blockSize * y));
        }
    }

    private string[] ReadLevelText()
    {
        TextAsset bindData = Resources.Load("0") as TextAsset;

        //string data = bindData.text.Replace(System.Environment.NewLine, string.Empty);
        return bindData.text.Split('-');
    }

    private string[] ReadLevelVisible()
    {
        TextAsset bindData = Resources.Load("visible") as TextAsset;

        //string data = bindData.text.Replace(System.Environment.NewLine, string.Empty);
        return bindData.text.Split('-');
    }

}
