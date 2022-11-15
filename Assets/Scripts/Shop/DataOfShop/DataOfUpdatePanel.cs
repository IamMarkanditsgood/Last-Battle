using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DataOfUpdatePanel : MonoBehaviour
{
    [SerializeField] private GameObject _nameOfUpdatedGun;
    [SerializeField] private GameObject _damageIndexText;
    [SerializeField] private GameObject _rechargeIndexText;
    [SerializeField] private GameObject _damagePriceText;
    [SerializeField] private GameObject _rechargePriceText;
    [SerializeField] private string _name;
    [SerializeField] private int _firstPrices;
    [SerializeField] private int _damageIndex;
    [SerializeField] private int _damagePrice;
    [SerializeField] private int _rechargeIndex;
    [SerializeField] private int _rechargePrice;
    [SerializeField] private DataOfGunPanel _dataOfGunPanel;

    public GameObject NameOfUpdatedGun
    {
        get { return _nameOfUpdatedGun; }
    }
    public GameObject DamageIndexText
    { get { return _damageIndexText; } set {  _damageIndexText = value; } }
    public GameObject RechargeIndexText
    { get { return _rechargeIndexText; } }
    public GameObject DamagePriceText
    { get { return _damagePriceText; } }
    public GameObject RechargePriceText
    { get { return _rechargePriceText; } }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public int FirstPrices { get { return _firstPrices; } set { _firstPrices = value;  } }
    public int DamageIndex
    {
        get { return _damageIndex; }
        set { _damageIndex = value; }
    }
    public int RechargeIndex
    {
        get { return _rechargeIndex; }
        set { _rechargeIndex = value; }
    }
    public int DamagePrice
    {
        get { return _damagePrice;  }
        set { _damagePrice = value; }
    }
    public int RechargePrice
    {
        get { return _rechargePrice; }
        set { _rechargePrice = value; }
    }
    public DataOfGunPanel DataOfGunPanel
    {
        get { return _dataOfGunPanel; }
        set { _dataOfGunPanel = value; }
    }

}
