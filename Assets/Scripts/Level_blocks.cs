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


        int mapX = mapData[0].ToCharArray().Length;

        int mapY = mapData.Length;

        Vector3 worldStart = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height/8));

        for (int y = 0; y < mapY; y++)
        {
            //txt.text += y + "   ";
            char[] newBlock = mapData[y].ToCharArray();

            for (int x = 0; x < mapX; x++)
            {
                PlaceBlock(newBlock[x].ToString(), x, y, worldStart);
                //txt.text += newBlock[x].ToString();
            }
            //txt.text += "\n";
        }
    }

    private void PlaceBlock(string blockType, int x, int y, Vector3 worldStart)
    {
        int blockIndex = int.Parse(blockType);


            GameObject newBlock = Instantiate(blocksTypes[blockIndex]);

            newBlock.transform.position = new Vector3(worldStart.x + (blockSize * x), worldStart.y - (blockSize * y));
        
    }

    private string[] ReadLevelText()
    {
        TextAsset bindData = Resources.Load("0") as TextAsset;

        //string data = bindData.text.Replace(System.Environment.NewLine, "-");
        return bindData.text.Split('-');
    }
}
