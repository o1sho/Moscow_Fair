using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class ChangeCharacterController : MonoBehaviour
{
    [SerializeField] private GameObject[] characters;


    private void Start()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            if (i == Database.Instance.selectedCharacter)
            {
                characters[i].SetActive(true);
                Database.Instance.selectedCharacter = i;
                Database.Instance.Save();
            }
            else characters[i].SetActive(false);
        }
    }


    public void ButtonRight()
    {
        if (Database.Instance.selectedCharacter < characters.Length - 1)
        {
            Database.Instance.selectedCharacter++;
            CharacterSelection(Database.Instance.selectedCharacter);
            Debug.Log("Character selected " + Database.Instance.selectedCharacter);
            Database.Instance.Save();
        }
        else Debug.Log("No more characters found!");
    }

    public void ButtonLeft()
    {
        if (Database.Instance.selectedCharacter > 0)
        {
            Database.Instance.selectedCharacter--;
            CharacterSelection(Database.Instance.selectedCharacter);
            Debug.Log("Character selected " + Database.Instance.selectedCharacter);
            Database.Instance.Save();
        }
        else Debug.Log("No more characters found!");
    }



    private void CharacterSelection(int idCharacter)
    {
        for (int i = 0; i < characters.Length; i++)
        {
            if (i == idCharacter)
            {
                characters[i].SetActive(true);
            } else characters[i].SetActive(false);
        }
    }

}
