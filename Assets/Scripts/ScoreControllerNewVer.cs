using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class ScoreControllerNewVer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    public static int score;

    [DllImport("__Internal")]
    private static extern void LeaderBoard(int maxScore);

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
#if !UNITY_EDITOR && UNITY_WEBGL
            LeaderBoard(DataManagerJSON_PREFS.instance.GetHighScore());
#endif
        }
    }

    private void OnDisable()
    {
        DataManagerJSON_PREFS.instance.SaveGameData();
#if !UNITY_EDITOR && UNITY_WEBGL
            LeaderBoard(DataManagerJSON_PREFS.instance.GetHighScore());
#endif
    }
}
