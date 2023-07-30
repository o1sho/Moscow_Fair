using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.Playables;
using static DataInfo;

[Serializable]
public class DataInfo
{
    public int coins;
    public int maxScore;
    public int countObj1;
    public int countObj2;
    public int countObj3;
    public int countObj4;
    public int selectedCharacter;
}

public class Database : MonoBehaviour
{
    public DataInfo dataInfo;

    public int coins;
    public int maxScore;
    public int countObj1;
    public int countObj2;
    public int countObj3;
    public int countObj4;
    public int selectedCharacter;
    public int hp;


    public static Database Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            Load();
        }
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/MySaveData.dat");
        DataInfo data = new DataInfo();

        data.coins = coins;
        data.maxScore = maxScore;
        data.countObj1 = countObj1;
        data.countObj2 = countObj2;
        data.countObj3 = countObj3;
        data.countObj4 = countObj4;
        data.selectedCharacter = selectedCharacter;
        bf.Serialize(file, data);
        file.Close();
        Debug.Log("Game data saved!");

    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/MySaveData.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/MySaveData.dat", FileMode.Open);
            DataInfo data = (DataInfo)bf.Deserialize(file);
            file.Close();
            coins = data.coins;
            maxScore = data.maxScore;
            countObj1 = data.countObj1;
            countObj2 = data.countObj2;
            countObj3 = data.countObj3;
            countObj4 = data.countObj4;
            selectedCharacter = data.selectedCharacter;
            Debug.Log("Game data loaded!");
        }
        else
            Debug.LogError("There is no save data!");
    }
}
