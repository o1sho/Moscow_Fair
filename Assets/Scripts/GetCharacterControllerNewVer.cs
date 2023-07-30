using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCharacterControllerNewVer : MonoBehaviour
{
    [SerializeField] GameObject[] characters;

    private void Awake()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            if (i != DataManagerJSON_PREFS.instance.GetSelectedCharacter()) Destroy(characters[i]);
        }
    }
}
