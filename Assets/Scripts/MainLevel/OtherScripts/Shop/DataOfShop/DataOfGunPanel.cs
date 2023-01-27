using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataOfGunPanel : MonoBehaviour
{
    [SerializeField] private ETypeOfGun _eTypeOfGun;
    [SerializeField] private bool _isBought = false;
    [SerializeField] private bool _isInstall = false;
    [SerializeField] private int _damageIndex;
    [SerializeField] private int _rechargeIndex;
    [SerializeField] private int _price;
    [SerializeField] private int _firstUpdatePrice;
    [SerializeField] private GameObject _buttonBuy;
    [SerializeField] private GameObject _buttonUpdate;
    [SerializeField] private GameObject _buttonInstall;
    [SerializeField] private GameObject _buttonInstalled;
    [SerializeField] private GameObject _updatePanel;

    public ETypeOfGun ETypeOfGun { get { return _eTypeOfGun; } set { _eTypeOfGun = value; } }
    public bool IsBought { get { return _isBought; } set { _isBought = value; } }
    public bool IsInstall { get { return _isInstall; } set { _isInstall = value; } }
    public int DamageIndex { get { return _damageIndex; } set { _damageIndex = value;} }
    public int RechargeIndex { get { return _rechargeIndex; } set { _rechargeIndex = value; } }
    public int Price { get { return _price; } set { _price = value; } }
    public int FirstUpdatePrice { get { return _firstUpdatePrice; } set { _firstUpdatePrice = value; } }    
    public GameObject ButtonBuy { get { return _buttonBuy; } }
    public GameObject ButtonUpdate { get { return _buttonUpdate; } }
    public GameObject ButtonInstall { get { return _buttonInstall; } }
    public GameObject ButtonInstalled { get { return _buttonInstalled; } }
    public GameObject UpdatePanel { get { return _updatePanel; } }
}
