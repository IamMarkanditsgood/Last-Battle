using UnityEngine;

public class ButtonsController : MonoBehaviour
{
    [SerializeField] private GameObject _startPanel;
    [SerializeField] private GameObject _endPanel;

    private LevelData _levelData;
    private LevelUIData _levelUIData;

    private void Start()
    {
        _levelData = LevelData.instance;
        _levelUIData = GetComponent<LevelUIData>();
    }
    private void Update()
    {
        if(_levelData.LoseLevel)
        {
            _endPanel.SetActive(true);
        }
    }
    public void OpenShop()
    {
        _levelUIData.MainDataOfCanvas.Shop.SetActive(true);
        _levelUIData.MainDataOfCanvas.IsShopOpen = true;
        _levelUIData.MainDataOfCanvas.SetCurrentPanel();
        _levelUIData.ShopButton.SetActive(false);
        Time.timeScale = 0;
    }
    public void PlayGame()
    {
        _startPanel.SetActive(false);
        _levelData.Player.SetActive(true);
        Time.timeScale = 1;
    }
    public void RestartGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
