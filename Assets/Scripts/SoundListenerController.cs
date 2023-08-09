using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundListenerController : MonoBehaviour
{
    public static SoundListenerController instance;

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
}
