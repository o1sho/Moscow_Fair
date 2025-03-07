using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class ScoreControllerNewVer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    public static int score;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        _scoreText.text = score.ToString();
    }

    public static void ScoreUp()
    {
        score++;
        if (score > DataManagerJSON_PREFS.instance.GetHighScore())
        {
            DataManagerJSON_PREFS.instance.SetHighScore(score);
        }
    }

    private void OnDisable()
    {
        DataManagerJSON_PREFS.instance.SaveGameData();
    }
}
