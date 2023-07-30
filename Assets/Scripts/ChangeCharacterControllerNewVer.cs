using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacterControllerNewVer : MonoBehaviour
{
    [SerializeField] private GameObject[] characters;


    private void Start()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            if (i == DataManagerJSON_PREFS.instance.GetSelectedCharacter())
            {
                characters[i].SetActive(true);
                DataManagerJSON_PREFS.instance.SetSelectedCharacter(i);
                Debug.Log("Character selected " + DataManagerJSON_PREFS.instance.GetSelectedCharacter());
            }
            else characters[i].SetActive(false);
        }
    }


    public void ButtonRight()
    {
        if (DataManagerJSON_PREFS.instance.GetSelectedCharacter() < characters.Length - 1)
        {
            DataManagerJSON_PREFS.instance.SetSelectedCharacter(DataManagerJSON_PREFS.instance.GetSelectedCharacter() + 1);
            CharacterSelection(DataManagerJSON_PREFS.instance.GetSelectedCharacter());
            Debug.Log("Character selected " + DataManagerJSON_PREFS.instance.GetSelectedCharacter());
        }
        else Debug.Log("No more characters found!");
    }

    public void ButtonLeft()
    {
        if (DataManagerJSON_PREFS.instance.GetSelectedCharacter() > 0)
        {
            DataManagerJSON_PREFS.instance.SetSelectedCharacter(DataManagerJSON_PREFS.instance.GetSelectedCharacter() - 1);
            CharacterSelection(DataManagerJSON_PREFS.instance.GetSelectedCharacter());
            Debug.Log("Character selected " + DataManagerJSON_PREFS.instance.GetSelectedCharacter());
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
            }
            else characters[i].SetActive(false);
        }
    }


}
