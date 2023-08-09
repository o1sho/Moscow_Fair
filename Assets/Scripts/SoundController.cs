using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundController : MonoBehaviour
{
    public static SoundController instance;

    [SerializeField] private AudioSource[] audioClips;

    [SerializeField] private GameObject MainMenuTheme;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound(int idAudioClip)
    {
        audioClips[idAudioClip].Play();
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            MainMenuTheme.SetActive(false);
        } else MainMenuTheme.SetActive(true);
    }
}
