using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public void OnButtonClick()
    {
        SoundController.instance.PlaySound(0);
    }

    public void OnButtonClickShop()
    {
        SoundController.instance.PlaySound(2);
    }
}
