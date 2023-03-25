using UnityEngine;
using UnityEngine.UI;

public class LevelUIData : MonoBehaviour
{
    [SerializeField] private MainDatas _mainDataOfCanvas;

    [SerializeField] private GameObject _shopButton;
    [SerializeField] private GameObject _score;
    [SerializeField] private GameObject _money;
    [SerializeField] private GameObject _startPanel;
    [SerializeField] private GameObject _endPanel;
    [SerializeField] private GameObject _miniMap;
    [SerializeField] private GameObject _largeMap;

    [SerializeField] private Image _healthLine;
    [SerializeField] private Image _shieldLine;
    [SerializeField] private Image _rechargeBar;

    [SerializeField] private float _multiplayerForHPAndShield;

    private bool _isFinded = false;

    public MainDatas MainDataOfCanvas
    {
        get { return _mainDataOfCanvas; }
    }

    public GameObject ShopButton{ get { return _shopButton; } }
    public GameObject Score { get { return _score; } }
    public GameObject Money { get { return _money; } }
    public GameObject StartPanel { get { return _startPanel; } }
    public GameObject EndPanel { get { return _endPanel; } }
    public GameObject MiniMap { get { return _miniMap; } }
    public GameObject LargeMap { get { return _largeMap; } }

    public Image HealthLine { get { return _healthLine; } }
    public Image ShieldLine { get { return _shieldLine; } }
    public Image RechargeBar { get { return _rechargeBar; } }

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
        else if (InitialValue / 100000 < 2 && !_isFinded)
        {
            _isFinded = true;
            return _multiplayerForHPAndShield = 0.00001f;
        }
        return _multiplayerForHPAndShield;
    }
}
