using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinsText;

    [SerializeField] private TextMeshProUGUI _countTextObj1;
    [SerializeField] private TextMeshProUGUI _countTextObj2;
    [SerializeField] private TextMeshProUGUI _countTextObj3;
    [SerializeField] private TextMeshProUGUI _countTextObj4;

    [SerializeField] private TextMeshProUGUI _priceTextObj1;
    [SerializeField] private TextMeshProUGUI _priceTextObj2;
    [SerializeField] private TextMeshProUGUI _priceTextObj3;
    [SerializeField] private TextMeshProUGUI _priceTextObj4;

    private void Start()
    {
        SetCoinsInfo();
        SetCountObj();
    }

    private void SetCoinsInfo()
    {
        _coinsText.text = Database.Instance.coins.ToString();
    }

    private void SetCountObj()
    {
        _countTextObj1.text = Database.Instance.countObj1.ToString();
        _countTextObj2.text = Database.Instance.countObj2.ToString();
        _countTextObj3.text = Database.Instance.countObj3.ToString();
        _countTextObj4.text = Database.Instance.countObj4.ToString();
    }

    public void SellObj(int objId)
    {
        switch (objId)
        {
            case 1:
                if (Database.Instance.countObj1 > 0)
                {
                    Database.Instance.countObj1--;
                    _countTextObj1.text = Database.Instance.countObj1.ToString();
                    Database.Instance.coins += int.Parse(_priceTextObj1.text);
                    _coinsText.text = Database.Instance.coins.ToString();
                    Debug.Log("Successful sale!");
                } else Debug.Log("The sale failed :(");
                break;
            case 2:
                if (Database.Instance.countObj2 > 0)
                {
                    Database.Instance.countObj2--;
                    _countTextObj2.text = Database.Instance.countObj2.ToString();
                    Database.Instance.coins += int.Parse(_priceTextObj2.text);
                    _coinsText.text = Database.Instance.coins.ToString();
                    Debug.Log("Successful sale!");
                } else Debug.Log("The sale failed :(");
                break;
            case 3:
                if (Database.Instance.countObj3 > 0)
                {
                    Database.Instance.countObj3--;
                    _countTextObj3.text = Database.Instance.countObj3.ToString();
                    Database.Instance.coins += int.Parse(_priceTextObj3.text);
                    _coinsText.text = Database.Instance.coins.ToString();
                    Debug.Log("Successful sale!");
                } else Debug.Log("The sale failed :(");
                break;
            case 4:
                if (Database.Instance.countObj4 > 0)
                {
                    Database.Instance.countObj4--;
                    _countTextObj4.text = Database.Instance.countObj4.ToString();
                    Database.Instance.coins += int.Parse(_priceTextObj4.text);
                    _coinsText.text = Database.Instance.coins.ToString();
                    Debug.Log("Successful sale!");
                } else Debug.Log("The sale failed :(");
                break;
                default:
                break;
        }
        Database.Instance.Save();
    }
}
