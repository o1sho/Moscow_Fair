using UnityEngine;
using System.IO;

[System.Serializable]
public class GameData
{
    public int coins;
    public int highScore;
    public int countObj1;
    public int countObj2;
    public int countObj3;
    public int countObj4;
    public int selectedCharacter;
    public int hp;
}

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    private string filePath;
    private GameData data;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            filePath = Path.Combine(Application.persistentDataPath, "gameData.json");
            LoadGameData();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        
    }

    public void SaveGameData()
    {
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(filePath, json);
    }

    public void LoadGameData()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            data = JsonUtility.FromJson<GameData>(json);
        }
        else
        {
            // Если файл не существует, создать новый объект GameData или задать значения по умолчанию.
            data = new GameData();
        }
    }

    //coins
    public void SetCoins(int coins)
    {
        data.coins = coins;
        SaveGameData();
    }

    public int GetCoins()
    {
        return data.coins;
    }
    //

    //highScore
    public void SetHighScore(int score)
    {
        data.highScore = score;
        SaveGameData();
    }

    public int GetHighScore()
    {
        return data.highScore;
    }
    //

    //countObj1
    public void SetCountObj1(int count)
    {
        data.countObj1 = count;
        SaveGameData();
    }

    public int GetCountObj1()
    {
        return data.countObj1;
    }
    //

    //countObj2
    public void SetCountObj2(int count)
    {
        data.countObj2 = count;
        SaveGameData();
    }

    public int GetCountObj2()
    {
        return data.countObj2;
    }
    //

    //countObj3
    public void SetCountObj3(int count)
    {
        data.countObj3 = count;
        SaveGameData();
    }

    public int GetCountObj3()
    {
        return data.countObj3;
    }
    //

    //countObj4
    public void SetCountObj4(int count)
    {
        data.countObj4 = count;
        SaveGameData();
    }

    public int GetCountObj4()
    {
        return data.countObj4;
    }
    //

    //selectedCharacter
    public void SetSelectedCharacter(int idCharacter)
    {
        data.selectedCharacter = idCharacter;
        SaveGameData();
    }

    public int GetSelectedCharacter()
    {
        return data.selectedCharacter;
    }
    //

    //hp
    public void SetHp(int count)
    {
        data.hp = count;
        SaveGameData();
    }

    public int GetHp()
    {
        return data.hp;
    }
    //
}
