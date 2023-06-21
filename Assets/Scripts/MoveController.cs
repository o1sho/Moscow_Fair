using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveController : MonoBehaviour
{
    public int posCharacter;

    public static MoveController instance;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        posCharacter = 0;
    }
    public void SetTurning(int _pos)
    {
        posCharacter = _pos;
    }
}
