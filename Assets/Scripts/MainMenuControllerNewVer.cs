using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenuControllerNewVer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coins;
    [SerializeField] private TextMeshProUGUI _maxScore;

    private void Start()
    {
        _coins.text = DataManagerJSON_PREFS.instance.GetCoins().ToString();
        _maxScore.text = DataManagerJSON_PREFS.instance.GetHighScore().ToString();
    }
}
