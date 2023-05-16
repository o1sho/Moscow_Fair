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

    public static void ScoreUp()
    {
        score++;
    }
}
