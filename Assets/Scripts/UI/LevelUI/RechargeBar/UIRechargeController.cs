using ShipData;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRechargeController : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Image _rechargeBar;
    
    public float rechargeTime;

    private DataOfGun _dataOfGun;
    private GameObject _usedGun;
    private float currentRechargeTime = 0;

    private void Update()
    {
        _usedGun = GetUsedGun();
        if (_usedGun != null)
        {
            _dataOfGun = _usedGun.GetComponent<DataOfGun>();

            if (!_dataOfGun.IsCharged)
            {
                rechargeTime = _dataOfGun.ReCharge;
                RechargeUI();
            }
            else
            {
                _rechargeBar.fillAmount = 1;
            }
        }    
    }
    public void RechargeUI()
    {

        if (currentRechargeTime <= rechargeTime)
        {
            currentRechargeTime += Time.deltaTime;
            _rechargeBar.fillAmount = currentRechargeTime / rechargeTime;
        }
        else
        {
            currentRechargeTime = 0;
        }
    }
    private GameObject GetUsedGun()
    {
        List<GameObject> playerGuns = _player.GetComponent<PlayerData>().TakeListOfGuns();

        for (int i = 0; i < playerGuns.Count; i++)
        {
            if (playerGuns[i].activeInHierarchy)
            {
                return playerGuns[i];
            }
        }
        return null;
    }
}
