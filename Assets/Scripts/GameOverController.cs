using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    public static GameOverController instance;

    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private bool _gameIsPause;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        gameOverPanel.SetActive(false);
        _gameIsPause = false;
        Time.timeScale = 1f;
    }

    public void OpenPanel()
    {
        Time.timeScale = 0f;
        gameOverPanel.SetActive(true);
        _gameIsPause = true;
    }

    public void ClosePanel()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
        _gameIsPause = false;
    }

    private void Update()
    {
        if (PlayerController.instance.health == 0) OpenPanel();
    }
}
