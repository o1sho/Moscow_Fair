using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjsController : MonoBehaviour
{
    public static ObjsController instance;

    [SerializeField] private TextMeshProUGUI _countTextObj1;
    [SerializeField] private TextMeshProUGUI _countTextObj2;
    [SerializeField] private TextMeshProUGUI _countTextObj3;
    [SerializeField] private TextMeshProUGUI _countTextObj4;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        SetCountObj();
    }
    public void SetCountObj()
    {
        _countTextObj1.text = Database.Instance.countObj1.ToString();
        _countTextObj2.text = Database.Instance.countObj2.ToString();
        _countTextObj3.text = Database.Instance.countObj3.ToString();
        _countTextObj4.text = Database.Instance.countObj4.ToString();
    }

}
