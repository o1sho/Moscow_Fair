using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Unity.Jobs;
using UnityEngine;

[System.Serializable]
public class Data
{
    public int coins;
    public int highScore;
    public int countObj0;
    public int countObj1;
    public int countObj2;
    public int countObj3;
    public int selectedCharacter;
    public int hp;
    public List<int> characterBuyedID = new List<int>() {0};
    public bool muteVolume;
}

public class DataManagerJSON_PREFS : MonoBehaviour
{
    public Data data;
    private string saveKey;

    public static DataManagerJSON_PREFS instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            data.highScore = 0;
        } 
           
    }

    public void SaveGameData()
    {
        string jsonData = JsonUtility.ToJson(data);

        PlayerPrefs.SetString(saveKey, jsonData);
        PlayerPrefs.Save();
    }

    public void LoadGameData()
    {
        if (PlayerPrefs.HasKey(saveKey))
        {
            string jsonData = PlayerPrefs.GetString(saveKey);
            data = JsonUtility.FromJson<Data>(jsonData); // Используем Unity JSON десериализатор
            Debug.Log("Data found, stored values loaded!");
        }
        else
        {
            // Если файл не существует, создать новый объект GameData или задать значения по умолчанию.
            data = new Data();
            Debug.Log("No data found, standard values loaded!");
        }
    }

    public void LoadGameDataYandex(string value)
    {
        data = JsonUtility.FromJson<Data>(value);
    }

    //coins
    public void SetCoins(int coins)
    {
        data.coins += coins;
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
    }

    public int GetHighScore()
    {
        return data.highScore;
    }
    //

    //countObj
    public void SetCountObj(int idObj, int count)
    {
        switch (idObj)
        {
            case 0:
                data.countObj0 += count;
                break;
            case 1:
                data.countObj1 += count;
                break;
            case 2:
                data.countObj2 += count;
                break;
            case 3:
                data.countObj3 += count;
                break;
        }
    }

    public int GetCountObj(int idObj)
    {
        switch (idObj)
        {
            case 0:
                return data.countObj0;
            case 1:
                return data.countObj1;
            case 2:
                return data.countObj2;
            case 3:
                return data.countObj3;
            default:
                return 0;
        }
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
    }

    public void SetHpTakeDamage(int count)
    {
        data.hp += count;
    }

    public int GetHp()
    {
        return data.hp;
    }
    //

    //charactedBuyedID
    public void SetCharactedBuyedID(int idCharacter)
    {
        data.characterBuyedID.Add(idCharacter);
    }

    public bool GetCharacterBuyedID(int idCharacter)
    {
        return data.characterBuyedID.Contains(idCharacter);
    }
    //

    //muteVolume
    public void SetMuteVolume(bool mute)
    {
        if (mute)
        {
            data.muteVolume = true;
        } else data.muteVolume = false;
    }

    public bool GetMuteVolume()
    {
        return data.muteVolume;
    }
}
