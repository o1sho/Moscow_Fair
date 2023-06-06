using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    public static int score;

    private int _maxSCore;

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
        if (score > Database.Instance.maxScore)
        {
            Database.Instance.maxScore = score;
        }
    }
}
