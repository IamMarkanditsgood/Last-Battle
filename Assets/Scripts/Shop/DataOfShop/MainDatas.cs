using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDatas : MonoBehaviour
{
    [SerializeField] private LevelUIData _mainLevelUI;
    [SerializeField] private GameObject _shop;
    [SerializeField] private GameObject _playersShip;
    [SerializeField] private GameObject _updateGunPanel;
    [SerializeField] private List<GameObject> _panelsOfShop;
    [SerializeField] private LevelData _levelData;
    [SerializeField] private int _money;
    [SerializeField] private bool _isShopOpen;
    private GameObject _currentPanel;

    private void Start()
    {
        
        gameObject.SetActive(true);
        for (int i =0; i < _panelsOfShop.Count;i++)
        {
            if(_panelsOfShop[i].activeInHierarchy)
            {
                _currentPanel = _panelsOfShop[i];
            }
        }
        
    }
    private void OnEnable()
    {
        _money = _levelData.Money;
    }
    public int Money
    {
        get { return _money; }
        set { _money = value; }
    }
    public GameObject CurrentPanel
    {
        get { return _currentPanel; }
        set { _currentPanel = value; }
    }
    public LevelUIData MainLevelUI
    {
        get { return _mainLevelUI; }
    }
    public GameObject Shop
    {
        get { return _shop; }
    }
    public GameObject PlayersShip{ get { return _playersShip; } }
    public GameObject UpdateGunPanel { get { return _updateGunPanel; } }

    public List<GameObject> PanelsOfShop
    {
        get { return _panelsOfShop; }
    }
    public bool IsShopOpen
    {
        get { return _isShopOpen; }
        set { _isShopOpen = value; }
    }
}
