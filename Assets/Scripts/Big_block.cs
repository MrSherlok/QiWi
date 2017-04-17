using UnityEngine;
using System;

public class Big_block : MonoBehaviour
{
    //[SerializeField]
    //private GameObject blockParent;


    [SerializeField]
    private GameObject[] blocksTypes;
    


    public float blockSize
    {
        get { return blocksTypes[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x; }
    }
    // Use this for initialization
    void Start()
    {
        Generate_block();
    }

    private void Generate_block()
    {
        string[] mapData = ReadLevelText();
        //string[] mapVisible = ReadLevelVisible();


        int mapX = mapData[0].ToCharArray().Length;

        int mapY = mapData.Length;

        //Vector3 worldStart = new Vector3(0f, 0f, 0f)/*Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height/8))*/;

        for (int y = 0; y < mapY; y++)
        {
            //txt.text += y + "   ";
            char[] newBlock = mapData[y].ToCharArray();
            //char[] blockVisible = mapVisible[y].ToCharArray();

            for (int x = 0; x < mapX; x++)
            {
                    PlaceBlock(newBlock[x].ToString(), x, y/*, worldStart*//*, blockVisible[x]*/);
                //txt.text += newBlock[x].ToString();
            }
            //txt.text += "\n";
        }
    }


    private void PlaceBlock(string blockType, int x, int y/*, Vector3 worldStart*//*, char blockVis*/)
    {
        int blockIndex = int.Parse(blockType);

        //if (blockIndex != 0)
        //{
        GameObject newBlock;
        //if (y >= 50)
        //{
        //    newBlock = Instantiate(blocksTypes[blockIndex + 10]);
        //}
        //else
        //{
            newBlock = Instantiate(blocksTypes[blockIndex]);
        //}
            //newBlock.GetComponent<BlockLogic>().PosX = x;
            //newBlock.GetComponent<BlockLogic>().PosY = y;
            newBlock.name = x + "_" + y;
            //if(blockVis == '0')
            //{
            //    ChangeColor(newBlock);
            //}
            newBlock.transform.parent = gameObject.transform;
            newBlock.transform.localPosition = new Vector3(/*worldStart.x +*/ (blockSize * x), /*worldStart.y -*/ (blockSize * -y));
        //}
    }



    private void ChangeColor(GameObject block)
    {
        block.GetComponent<SpriteRenderer>().enabled = true;
    }


    //private void ChangeColor(GameObject block)
    //{
    //    int children = block.transform.childCount;
    //    for (int i = 0; i < children; ++i)
    //    {
    //        if (block.transform.GetChild(i) != null)
    //        {
    //            block.transform.GetChild(i).GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 255);
    //        }
    //    }
    //}

    private string[] ReadLevelText()
    {
        TextAsset bindData = Resources.Load(gameObject.name) as TextAsset;
        string data = bindData.text.Replace(Environment.NewLine, string.Empty);

        return data.Split('-');
    }

    //private string[] ReadLevelVisible()
    //{
    //    TextAsset bindData = Resources.Load("visible") as TextAsset;

    //    //string data = bindData.text.Replace(System.Environment.NewLine, string.Empty);
    //    return bindData.text.Split('-');
    //}

}
