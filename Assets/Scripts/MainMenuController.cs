using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coins;
    [SerializeField] private TextMeshProUGUI _maxScore;

    private void Start()
    {
        _coins.text = Database.Instance.coins.ToString();
        _maxScore.text = Database.Instance.maxScore.ToString();
    }
}
