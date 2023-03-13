using UnityEngine;
using TMPro;

public class DataOfPlayerPanel : MonoBehaviour
{
    [SerializeField] private MainDatas _mainShopData;

    [SerializeField] private GameObject _priceHPText;
    [SerializeField] private GameObject _priceSieldText;
    [SerializeField] private GameObject _amountOfHP;
    [SerializeField] private GameObject _amountOfSield;

    [SerializeField] private int _currentPriceOfHP;
    [SerializeField] private int _priceIndexOfHP;
    [SerializeField] private int _currentPriceOfShield;
    [SerializeField] private int _priceIndexOfShield;
    [SerializeField] private int _HealtheAmount;
    [SerializeField] private int _ShieldAmount;

    public void Start()
    {
        _priceHPText.GetComponent<TextMeshProUGUI>().SetText(_currentPriceOfHP.ToString());
        _priceSieldText.GetComponent<TextMeshProUGUI>().SetText(_currentPriceOfShield.ToString());
        _amountOfHP.GetComponent<TextMeshProUGUI>().SetText(_HealtheAmount.ToString());
        _amountOfSield.GetComponent<TextMeshProUGUI>().SetText(_ShieldAmount.ToString());
    }
    public MainDatas MainShopData
    {
        get { return _mainShopData; }
    }

    public GameObject PriceHPText { get { return _priceHPText; } }
    public GameObject PriceSieldText { get { return _priceSieldText; } }
    public GameObject AmountOfHP { get { return _amountOfHP; } }
    public GameObject AmountOfShield { get { return _amountOfSield; } }

    public int CurrentPriceOfHP { get { return _currentPriceOfHP; } set { _currentPriceOfHP = value; } }
    public int PriceIndexOfHP { get { return _priceIndexOfHP; } set { _priceIndexOfHP = value; } }
    public int CurrentPriceOfShield { get { return _currentPriceOfShield; } set { _currentPriceOfShield = value; } }
    public int PriceIndexOfShield { get { return _priceIndexOfShield; } set { _priceIndexOfShield = value; } }
    public int HealtheAmount { get { return _HealtheAmount; } set { _HealtheAmount = value; } }
    public int ShieldAmount { get { return _ShieldAmount; } set { _ShieldAmount = value; } }
}
