using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseShopPanel : MonoBehaviour
{
    [SerializeField] private GameObject _UIThatShoodBeClosed;
    [SerializeField] private MainDatas _MainDatas;

    public void CloseShop()
    {
        Time.timeScale = 1;
        _MainDatas.IsShopOpen = false;
        _UIThatShoodBeClosed.SetActive(false);

    }
}
