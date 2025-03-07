using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
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

    /*
    public static void ScoreUp()
    {
        score++;
        if (score > Database.Instance.maxScore)
        {
            Database.Instance.maxScore = score;
        }
    }
    */
    public void ScoreUp()
    {
        score++;
        if (score > DataManagerJSON_PREFS.instance.GetHighScore())
        {
            DataManagerJSON_PREFS.instance.SetHighScore(score);
            SaveLeaderBoard();
        }

    }

    private void SaveLeaderBoard()
    {

    }
}
