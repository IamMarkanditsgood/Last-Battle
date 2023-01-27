using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class LevelUIData : MonoBehaviour
{
    [SerializeField] private MainDatas _mainDataOfCanvas;
    [SerializeField] private GameObject _shopButton;
    [SerializeField] private Image _healthLine;
    [SerializeField] private Image _shieldLine;
    [SerializeField] private float _multiplayerForHPAndShield;
    private bool _isFinded = false;

    public MainDatas MainDataOfCanvas
    {
        get { return _mainDataOfCanvas; }
    }
    public GameObject ShopButton{ get { return _shopButton; } }
    public Image HealthLine { get { return _healthLine; } }
    public Image ShieldLine { get { return _shieldLine; } }
    public float GetMultiplierForHPAndShield(float InitialValue )
    {
        if((InitialValue / 100) < 2 && !_isFinded)
        {
            _isFinded = true;
            return _multiplayerForHPAndShield = 0.01f;

        }
        else if(InitialValue / 1000 < 2 && !_isFinded)
        {
            _isFinded = true;
            return _multiplayerForHPAndShield = 0.001f;
        }
        else if (InitialValue / 10000 < 2 && !_isFinded)
        {
            _isFinded = true;
            return _multiplayerForHPAndShield = 0.0001f;
        }
       
        return _multiplayerForHPAndShield;
    }
}
