using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsController : MonoBehaviour
{
    private LevelUIData _levelUIData;

    private void Start()
    {
        _levelUIData = GetComponent<LevelUIData>();
    }
    public void OpenShop()
    {

        _levelUIData.MainDataOfCanvas.Shop.SetActive(true);
        _levelUIData.ShopButton.SetActive(false);
        _levelUIData.MainDataOfCanvas.IsShopOpen = true;
        Time.timeScale = 0;
        
    }
}
