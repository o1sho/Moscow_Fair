using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    [SerializeField] private GameObject[] playersTurns;

    [SerializeField] private GameObject[] healthPoints;
    public int health;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        for (var i = 0; i < playersTurns.Length; i++)
        {
            if (playersTurns[i].name == "PlayerCenter")
            {
                playersTurns[i].SetActive(true);
            }
            else playersTurns[i].SetActive(false);
        }
    }

    public void TurnLeftUp()
    {
        Debug.Log("Player Turm left up");
        for (var i = 0; i < playersTurns.Length; i++)
        {
            if (playersTurns[i].name == "PlayerLeftUp")
            {
                playersTurns[i].SetActive(true);
            }
            else playersTurns[i].SetActive(false);
        }
    }

    public void TurnRightUp()
    {
        Debug.Log("Player Turm right up");
        for (var i = 0; i < playersTurns.Length; i++)
        {
            if (playersTurns[i].name == "PlayerRightUp")
            {
                playersTurns[i].SetActive(true);
            }
            else playersTurns[i].SetActive(false);
        }
    }

    public void TurnLeftDown()
    {
        Debug.Log("Player Turm left down");
        for (var i = 0; i < playersTurns.Length; i++)
        {
            if (playersTurns[i].name == "PlayerLeftDown")
            {
                playersTurns[i].SetActive(true);
            }
            else playersTurns[i].SetActive(false);
        }
    }

    public void TurnRightDown()
    {
        Debug.Log("Player Turm right down");
        for (var i = 0; i < playersTurns.Length; i++)
        {
            if (playersTurns[i].name == "PlayerRightDown")
            {
                playersTurns[i].SetActive(true);
            }
            else playersTurns[i].SetActive(false);
        }
    }

    public void TakeDamage(int count)
    {
        health -= count;
        for (int i = 0; i < healthPoints.Length; i++)
        {
            if (i < health)
            {
                healthPoints[i].SetActive(true);
            } else healthPoints[i].SetActive(false);    
        }
    }
}
