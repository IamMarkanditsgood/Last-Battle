using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ShipData;
public class PlayerPanelController : MonoBehaviour
{
    private const int numberWhichAddToShieldAndHP = 100;
    [SerializeField] private DataOfPlayerPanel _dataOfPlayerPanel;
    private MainDatas _mainData;
    void Start()
    {
        _mainData = _dataOfPlayerPanel.MainShopData;
    }
    public void AddHP()
    {
        if(_mainData.Money >= _dataOfPlayerPanel.CurrentPriceOfHP)
        {
            _mainData.Money -= _dataOfPlayerPanel.CurrentPriceOfHP;
            _dataOfPlayerPanel.PriceIndexOfHP++;
            _dataOfPlayerPanel.CurrentPriceOfHP = _dataOfPlayerPanel.CurrentPriceOfHP * _dataOfPlayerPanel.PriceIndexOfHP;
            _dataOfPlayerPanel.HealtheAmount += numberWhichAddToShieldAndHP;
            _mainData.PlayersShip.GetComponent<PlayerData>().SetHealth(_mainData.PlayersShip.GetComponent<PlayerData>().GetHealth() + numberWhichAddToShieldAndHP);
            _dataOfPlayerPanel.PriceHPText.GetComponent<TextMeshProUGUI>().SetText(_dataOfPlayerPanel.CurrentPriceOfHP.ToString());
            _dataOfPlayerPanel.AmountOfHP.GetComponent<TextMeshProUGUI>().SetText(_dataOfPlayerPanel.HealtheAmount.ToString());
        }
        else
        {
            Debug.Log("We need more gold!!!");
        }
    }
    public void AddShield()
    {
        if (_mainData.Money >= _dataOfPlayerPanel.CurrentPriceOfShield)
        {
            _mainData.Money -= _dataOfPlayerPanel.CurrentPriceOfShield;
            _dataOfPlayerPanel.PriceIndexOfShield++;
            _dataOfPlayerPanel.CurrentPriceOfShield = _dataOfPlayerPanel.CurrentPriceOfShield * _dataOfPlayerPanel.PriceIndexOfShield;
            _dataOfPlayerPanel.ShieldAmount += numberWhichAddToShieldAndHP;
            _mainData.PlayersShip.GetComponent<PlayerData>().SetShield(_mainData.PlayersShip.GetComponent<PlayerData>().GetShield() + numberWhichAddToShieldAndHP);
            _dataOfPlayerPanel.PriceSieldText.GetComponent<TextMeshProUGUI>().SetText(_dataOfPlayerPanel.CurrentPriceOfShield.ToString());
            _dataOfPlayerPanel.AmountOfShield.GetComponent<TextMeshProUGUI>().SetText(_dataOfPlayerPanel.ShieldAmount.ToString());
        }
        else
        {
            Debug.Log("We need more gold!!!");
        }
    }

}
