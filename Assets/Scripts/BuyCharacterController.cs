using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuyCharacterController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI priceCharacter;
    [SerializeField] private int idCharacter;
    [SerializeField] private TextMeshProUGUI coinsText;

    private void OnEnable()
    {
        if (DataManagerJSON_PREFS.instance.GetCharacterBuyedID(idCharacter))
        {
            gameObject.SetActive(false);
        }
        coinsText.text = DataManagerJSON_PREFS.instance.GetCoins().ToString();
    }

    public void BuyCharacter()
    {
        if (DataManagerJSON_PREFS.instance.GetCoins() >= int.Parse(priceCharacter.text))
        {
            gameObject.SetActive(false);
            DataManagerJSON_PREFS.instance.SetCoins(- int.Parse(priceCharacter.text));
            coinsText.text = DataManagerJSON_PREFS.instance.GetCoins().ToString();
            DataManagerJSON_PREFS.instance.SetCharactedBuyedID(idCharacter);
        }
        else
        {
            Debug.Log("Not enough coins!");
        }
    }
}
