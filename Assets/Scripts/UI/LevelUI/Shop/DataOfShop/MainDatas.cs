using System.Collections.Generic;
using UnityEngine;

public class MainDatas : MonoBehaviour
{
    [SerializeField] private LevelUIData _mainLevelUI;
    [SerializeField] private LevelData _levelData;

    [SerializeField] private List<GameObject> _panelsOfShop;

    [SerializeField] private GameObject _shop;
    [SerializeField] private GameObject _playersShip;
    [SerializeField] private GameObject _updateGunPanel;
    [SerializeField] private GameObject _currentPanel;
    [SerializeField] private GameObject _messagePanel;

    [SerializeField] private bool _isShopOpen;

    public LevelUIData MainLevelUI
    {
        get { return _mainLevelUI; }
    }

    public List<GameObject> PanelsOfShop
    {
        get { return _panelsOfShop; }
    }

    public GameObject CurrentPanel
    {
        get { return _currentPanel; }
        set { _currentPanel = value; }
    }
    public GameObject Shop
    {
        get { return _shop; }
    }
    public GameObject PlayersShip { get { return _playersShip; } }
    public GameObject UpdateGunPanel { get { return _updateGunPanel; } }
    public GameObject MessagePanel { get { return _messagePanel; } }
    
    public bool IsShopOpen
    {
        get { return _isShopOpen; }
        set { _isShopOpen = value; }
    }

    public void SetCurrentPanel()
    {
        gameObject.SetActive(true);
        for (int i = 0; i < _panelsOfShop.Count; i++)
        {
            if (_panelsOfShop[i].activeInHierarchy)
            {
                _currentPanel = _panelsOfShop[i];
            }
        }
    }
}
