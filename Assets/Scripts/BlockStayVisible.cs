using UnityEngine;
using System.IO;

public class BlockStayVisible : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.GetComponent<BlockLogic>() != null) {
            
            UpdateWorld(col.gameObject.GetComponent<BlockLogic>().PosX, col.gameObject.GetComponent<BlockLogic>().PosY);            
        }
    }

    private void UpdateWorld(int _posX, int _posY)
    {
        char[] mapVisible = ReadLevelVisible();

        int maxX = mapVisible.Length;

        int place = _posY * 101 + _posX;
        mapVisible[place] = '1';

        string txtFull = "";

        for (int x = 0; x < maxX; x++)
            txtFull += mapVisible[x].ToString();

        File.AppendAllText("Resources/visible.txt", txtFull);



    }

    private char[] ReadLevelVisible()
    {
        TextAsset bindData = Resources.Load("visible") as TextAsset;

        //string data = bindData.text.Replace(System.Environment.NewLine, string.Empty);
        return bindData.text.ToCharArray();
    }
}
