using UnityEngine;
using TMPro;
using ShipData;

public class PlayerPanelController : MonoBehaviour
{
    private const int numberWhichAddToShieldAndHP = 100;

    [SerializeField] private DataOfPlayerPanel _dataOfPlayerPanel;
    [SerializeField] private MainDatas _mainDatas;

    private SoundsController _soundController = new SoundsController();

    private LevelData _levelData;
    void Start()
    {
        _levelData = LevelData.instance;
    }
    public void AddHP()
    {
        _soundController.UseSound(ETypeOfSound.ButtonSound);

        if (_levelData.Money >= _dataOfPlayerPanel.CurrentPriceOfHP)
        {
            _levelData.Money -= _dataOfPlayerPanel.CurrentPriceOfHP;
            _dataOfPlayerPanel.PriceIndexOfHP++;
            _dataOfPlayerPanel.CurrentPriceOfHP = _dataOfPlayerPanel.CurrentPriceOfHP * _dataOfPlayerPanel.PriceIndexOfHP;
            _dataOfPlayerPanel.HealtheAmount += numberWhichAddToShieldAndHP;

            _levelData.Player.GetComponent<PlayerData>().SetHealth(_levelData.Player.GetComponent<PlayerData>().GetHealth() + numberWhichAddToShieldAndHP);
            _dataOfPlayerPanel.PriceHPText.GetComponent<TextMeshProUGUI>().SetText(_dataOfPlayerPanel.CurrentPriceOfHP.ToString());
            _dataOfPlayerPanel.AmountOfHP.GetComponent<TextMeshProUGUI>().SetText(_dataOfPlayerPanel.HealtheAmount.ToString());
        }
        else
        {
            ActivateErrorMessage();
        }
    }
    public void AddShield()
    {
        _soundController.UseSound(ETypeOfSound.ButtonSound);

        if (_levelData.Money >= _dataOfPlayerPanel.CurrentPriceOfShield)
        {
            _levelData.Money -= _dataOfPlayerPanel.CurrentPriceOfShield;
            _dataOfPlayerPanel.PriceIndexOfShield++;
            _dataOfPlayerPanel.CurrentPriceOfShield = _dataOfPlayerPanel.CurrentPriceOfShield * _dataOfPlayerPanel.PriceIndexOfShield;
            _dataOfPlayerPanel.ShieldAmount += numberWhichAddToShieldAndHP;

            _levelData.Player.GetComponent<PlayerData>().SetShield(_levelData.Player.GetComponent<PlayerData>().GetShield() + numberWhichAddToShieldAndHP);
            _dataOfPlayerPanel.PriceSieldText.GetComponent<TextMeshProUGUI>().SetText(_dataOfPlayerPanel.CurrentPriceOfShield.ToString());
            _dataOfPlayerPanel.AmountOfShield.GetComponent<TextMeshProUGUI>().SetText(_dataOfPlayerPanel.ShieldAmount.ToString());
        }
        else
        {
            ActivateErrorMessage();
        }
    }

    private void ActivateErrorMessage()
    {
        GameObject messagePanel = _mainDatas.MessagePanel.GetComponent<MessagePanelData>().NotEnoughMoneyPanel;
        messagePanel.SetActive(true);
    }
}
