using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCharacterController : MonoBehaviour
{
    [SerializeField] private Button[] buttonCharacters;


    private void Start()
    {
        if (Database.Instance.selectedCharacter == 0)
        {
            SetCharacter(1);
        } else
        {
            SetCharacter(Database.Instance.selectedCharacter);
        }

        for (int i = 0; i <= 2; i++)
        {
            if (i != Database.Instance.selectedCharacter - 1)
            {
                Color currentColor = buttonCharacters[i].image.color;
                buttonCharacters[i].image.color = new Color(currentColor.r, currentColor.g, currentColor.b, 0.5f);
            }
        }
    }

    public void SetCharacter(int characterID)
    {
        Database.Instance.selectedCharacter = characterID;
        Database.Instance.Save();
        for (int i = 0; i <= 2; i++)
        {
            Color currentColor = buttonCharacters[i].image.color;
            if (i != characterID - 1)
            {
                buttonCharacters[i].image.color = new Color(currentColor.r, currentColor.g, currentColor.b, 0.5f);
            } else buttonCharacters[i].image.color = new Color(currentColor.r, currentColor.g, currentColor.b, 1f);
        }
        Database.Instance.hp = 0;
        Debug.Log("Set Character " + characterID + "!");
    }


}
