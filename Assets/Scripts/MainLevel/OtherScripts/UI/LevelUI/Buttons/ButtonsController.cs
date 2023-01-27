using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsController : MonoBehaviour
{
    private LevelData _levelData;
    private LevelUIData _levelUIData;
    [SerializeField] private GameObject _startPanel;
    [SerializeField] private GameObject _endPanel;

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
        _levelUIData.ShopButton.SetActive(false);
        _levelUIData.MainDataOfCanvas.IsShopOpen = true;
        _levelUIData.MainDataOfCanvas.SetCurrentPanel();
        Time.timeScale = 0;
    }
    public void PlayGame()
    {
        Time.timeScale = 1;
        _startPanel.SetActive(false);
    }
    public void RestartGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
