using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnBecomeInvisible : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
