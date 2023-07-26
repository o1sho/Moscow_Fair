using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCharacterController : MonoBehaviour
{
    [SerializeField] GameObject[] characters;

    private void Awake()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            if (i != Database.Instance.selectedCharacter) Destroy(characters[i]);
        }
    }
}
