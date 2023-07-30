using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private GameObject playerTurn1;
    [SerializeField] private GameObject playerTurn2;
    [SerializeField] private GameObject playerTurn3;
    [SerializeField] private GameObject playerTurn4;
    [SerializeField] private GameObject playerTurnCenter;

    [SerializeField] private GameObject[] hpSpriteUI;
    [SerializeField] private int hp;

    private void Start()
    {
        playerTurnCenter.SetActive(true);
        playerTurn1.SetActive(false);
        playerTurn2.SetActive(false);
        playerTurn3.SetActive(false);
        playerTurn4.SetActive(false);

        DataManagerJSON_PREFS.instance.SetHp(hp);
        Debug.Log("Character have HP: " + DataManagerJSON_PREFS.instance.GetHp());
    }

    private void Update()
    {
        switch (MoveController.instance.posCharacter)
        {
            case 1:
                playerTurn1.SetActive(true);
                playerTurn2.SetActive(false);
                playerTurn3.SetActive(false);
                playerTurn4.SetActive(false);
                playerTurnCenter.SetActive(false);
                break;
            case 2:
                playerTurn1.SetActive(false);
                playerTurn2.SetActive(true);
                playerTurn3.SetActive(false);
                playerTurn4.SetActive(false);
                playerTurnCenter.SetActive(false);
                break;
            case 3:
                playerTurn1.SetActive(false);
                playerTurn2.SetActive(false);
                playerTurn3.SetActive(true);
                playerTurn4.SetActive(false);
                playerTurnCenter.SetActive(false);
                break;
            case 4:
                playerTurn1.SetActive(false);
                playerTurn2.SetActive(false);
                playerTurn3.SetActive(false);
                playerTurn4.SetActive(true);
                playerTurnCenter.SetActive(false);
                break;
        }

        for (int i = 1; i <= hpSpriteUI.Length; i++)
        {
            if (i > DataManagerJSON_PREFS.instance.GetHp())
            {
                hpSpriteUI[i - 1].SetActive(false);
            }
        }
        if (DataManagerJSON_PREFS.instance.GetHp() == 0)
        {
            GameOverController.instance.OpenPanel();
        }

    }

}
