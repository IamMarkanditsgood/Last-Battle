using UnityEngine;

public class ShopAreaController
{
    private const float _distanceForUseingShop = 5; // Shop area size / 2

    private float _currentDistance;

    public void IsCanUseShop(MainDatas mainDatasOfCanvas, GameObject shopArea)
    {
        LevelData _levelData = LevelData.instance;

        if (!mainDatasOfCanvas.IsShopOpen && _levelData.IsPeacefulTime)
        {
            _currentDistance = Vector3.Distance(shopArea.transform.position, _levelData.Player.transform.position);
            if (_currentDistance <= _distanceForUseingShop)
            {
                mainDatasOfCanvas.MainLevelUI.ShopButton.SetActive(true);
            }
            else
            {
                mainDatasOfCanvas.MainLevelUI.ShopButton.SetActive(false);
            }
        }
    }
}
