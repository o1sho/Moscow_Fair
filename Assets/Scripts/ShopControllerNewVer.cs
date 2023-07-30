using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;

public class ShopControllerNewVer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinsText;

    [SerializeField] private TextMeshProUGUI _countTextObj0;
    [SerializeField] private TextMeshProUGUI _countTextObj1;
    [SerializeField] private TextMeshProUGUI _countTextObj2;
    [SerializeField] private TextMeshProUGUI _countTextObj3;

    [SerializeField] private TextMeshProUGUI _priceTextObj0;
    [SerializeField] private TextMeshProUGUI _priceTextObj1;
    [SerializeField] private TextMeshProUGUI _priceTextObj2;
    [SerializeField] private TextMeshProUGUI _priceTextObj3;

    private void Start()
    {
        SetCoinsInfo();
        SetCountObj();
    }



    private void SetCoinsInfo()
    {
        _coinsText.text = DataManagerJSON_PREFS.instance.GetCoins().ToString();
    }

    private void SetCountObj()
    {
        _countTextObj0.text = DataManagerJSON_PREFS.instance.GetCountObj(0).ToString();
        _countTextObj1.text = DataManagerJSON_PREFS.instance.GetCountObj(1).ToString();
        _countTextObj2.text = DataManagerJSON_PREFS.instance.GetCountObj(2).ToString();
        _countTextObj3.text = DataManagerJSON_PREFS.instance.GetCountObj(3).ToString();
    }



    public void SellObj(int objId)
    {
        SellProcces(objId);
        SetCoinsInfo();
        SetCountObj();
    }

    private void SellProcces(int objId)
    {
        if (DataManagerJSON_PREFS.instance.GetCountObj(objId) > 0)
        {
            DataManagerJSON_PREFS.instance.SetCountObj(objId, -1);
            _countTextObj1.text = DataManagerJSON_PREFS.instance.GetCountObj(objId).ToString();
            DataManagerJSON_PREFS.instance.SetCoins(GetPrice(objId)); //Цена фрукта
            _coinsText.text = DataManagerJSON_PREFS.instance.GetCoins().ToString();
            Debug.Log("Successful sale!");
        }
        else Debug.Log("The sale failed :(");
    }

    private int GetPrice(int idObj)
    {
        switch (idObj)
        {
            case 0:
                return int.Parse(_priceTextObj0.text);
            case 1:
                return int.Parse(_priceTextObj1.text);
            case 2:
                return int.Parse(_priceTextObj2.text);
            case 3:
                return int.Parse(_priceTextObj3.text);
            default: return 0;
        }
    }

    private void OnDisable()
    {
        DataManagerJSON_PREFS.instance.SaveGameData();
    }
}
