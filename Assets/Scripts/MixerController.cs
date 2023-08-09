using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerController : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;

    [SerializeField] private GameObject spriteMute;
    [SerializeField] private GameObject spriteUnMute;

    private void Start()
    {
        if (DataManagerJSON_PREFS.instance.GetMuteVolume())
        {
            spriteMute.SetActive(false);
            spriteUnMute.SetActive(true);
            mixer.SetFloat("MasterVolume", -80);
        } else
        {
            spriteMute.SetActive(true);
            spriteUnMute.SetActive(false);
            mixer.SetFloat("MasterVolume", 0);
        }
    }

    public void MuteVolume()
    {
        mixer.SetFloat("MasterVolume", -80);

        DataManagerJSON_PREFS.instance.SetMuteVolume(true);
        spriteMute.SetActive(false);
        spriteUnMute.SetActive(true);
        DataManagerJSON_PREFS.instance.SaveGameData();
    }

    public void UnMuteVolume()
    {
        mixer.SetFloat("MasterVolume", 0);

        DataManagerJSON_PREFS.instance.SetMuteVolume(false);
        spriteMute.SetActive(true);
        spriteUnMute.SetActive(false);
        DataManagerJSON_PREFS.instance.SaveGameData();
    }
}
