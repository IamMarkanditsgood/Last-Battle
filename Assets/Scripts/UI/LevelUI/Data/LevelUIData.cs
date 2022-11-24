using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUIData : MonoBehaviour
{
    [SerializeField] private MainDatas _mainDataOfCanvas;
    [SerializeField] private GameObject _shopButton;

    public MainDatas MainDataOfCanvas
    {
        get { return _mainDataOfCanvas; }
    }
    public GameObject ShopButton{ get { return _shopButton; } }
}
