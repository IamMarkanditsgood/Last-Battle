using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopAreaController : MonoBehaviour
{
    private const float _distanceForUseShop = 5; // Shop area size / 2

    [SerializeField] private MainDatas _mainDatasOfCanvas;
    private float _currentDistance;
    private LevelData _levelData;
    

    private void Start()
    {
        _levelData = LevelData.instance;
    }

    private void Update()
    {
        if (!_levelData.MainDatas.IsShopOpen)
        {
            _currentDistance = Vector3.Distance(gameObject.transform.position, _levelData.Player.transform.position);
            if (_currentDistance <= _distanceForUseShop)
            {
                _mainDatasOfCanvas.MainLevelUI.ShopButton.SetActive(true);
            }
            else
            {
                _mainDatasOfCanvas.MainLevelUI.ShopButton.SetActive(false);
            }
        }
    }
}
