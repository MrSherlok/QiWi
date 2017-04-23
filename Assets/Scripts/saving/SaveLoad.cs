using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{

    public static int ccoins = 8;
    private void Start()
    {
        Debug.Log(ccoins);
        Save();
        Debug.Log(ccoins);
        Load();
        Debug.Log(ccoins);
    }

    public static void Save()
    {
        BinaryFormatter binary = new BinaryFormatter();
        FileStream fStream = File.Create(Application.persistentDataPath + "/turbocoinSaveFile.sav");

        SaveManager sManager = new SaveManager();
        sManager.coins = 10;
        sManager.coinsTotalEver = 15;
        sManager.totalTurbosEver = 20;

        binary.Serialize(fStream, sManager);
        fStream.Close();
    }

    public static void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/turbocoinSaveFile.sav"))
        {
            BinaryFormatter binary = new BinaryFormatter();
            FileStream fStream = File.Open(Application.persistentDataPath + "/turbocoinSaveFile.sav", FileMode.Open);
            SaveManager sManager = (SaveManager)binary.Deserialize(fStream);
            fStream.Close();

            ccoins = sManager.coins;
           
        }
    }

    [System.Serializable]
    class SaveManager
    {
        public int coins;
        public int coinsTotalEver;
        public int totalTurbosEver;
    }
}
