using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ShipData;

public class UpdatePanelController : MonoBehaviour
{
    [SerializeField] private MainDatas mainData;

    public void SetDATA(DataOfGunPanel dataOfGunPanel,  DataOfUpdatePanel dataOfUpdatePanel)
    {
         DataOfGunPanel _gunPanelData;

        _gunPanelData = dataOfGunPanel;
        dataOfUpdatePanel.Name = _gunPanelData.ETypeOfGun.ToString();
        dataOfUpdatePanel.DamageIndex = _gunPanelData.DamageIndex;
        dataOfUpdatePanel.DamagePrice = dataOfUpdatePanel.FirstPrices * dataOfUpdatePanel.DamageIndex;
        dataOfUpdatePanel.RechargeIndex = _gunPanelData.RechargeIndex;
        dataOfUpdatePanel.RechargePrice = dataOfUpdatePanel.FirstPrices * dataOfUpdatePanel.RechargeIndex;
       
        SetPanelsText(dataOfUpdatePanel);
    }
    private void SetPanelsText(DataOfUpdatePanel dataOfUpdatePanel)
    {
        dataOfUpdatePanel.NameOfUpdatedGun.GetComponent<TextMeshProUGUI>().SetText(dataOfUpdatePanel.Name);
        dataOfUpdatePanel.DamageIndexText.GetComponent<TextMeshProUGUI>().SetText(dataOfUpdatePanel.DamageIndex.ToString());
        dataOfUpdatePanel.RechargeIndexText.GetComponent<TextMeshProUGUI>().SetText(dataOfUpdatePanel.RechargeIndex.ToString());
        dataOfUpdatePanel.DamagePriceText.GetComponent<TextMeshProUGUI>().SetText(dataOfUpdatePanel.DamagePrice.ToString());
        dataOfUpdatePanel.RechargePriceText.GetComponent<TextMeshProUGUI>().SetText(dataOfUpdatePanel.RechargePrice.ToString());
    }
    public void AddDamage()
    {
        LevelData levelData = LevelData.instance;
        DataOfUpdatePanel dataOfUpdatePanel = GetComponent<DataOfUpdatePanel>();
        if (levelData.Money >= dataOfUpdatePanel.DamagePrice)
        {
            DataOfGunPanel dataOfGunPanel = gameObject.GetComponent<DataOfUpdatePanel>().DataOfGunPanel;
            dataOfGunPanel.DamageIndex++;

            PlayerData playerData = mainData.PlayersShip.GetComponent<PlayerData>();
            List<GameObject> gunList = playerData.TakeListOfGuns();

            levelData.Money -= dataOfUpdatePanel.DamagePrice;
            for (int i = 0; i < gunList.Count; i++)
            {
                DataOfGun gunData = gunList[i].GetComponent<DataOfGun>();
                if (gunData.TypeOfGun == dataOfGunPanel.ETypeOfGun)
                {
                    

                    gunData.DamageIndex = dataOfGunPanel.DamageIndex;
                    gunData.ReSetDamage();
                }
            }
            SetDATA(dataOfGunPanel, gameObject.GetComponent<DataOfUpdatePanel>());
        }
    }
    public void AddRecharge()
    {
        LevelData levelData = LevelData.instance;
        DataOfUpdatePanel dataOfUpdatePanel = GetComponent<DataOfUpdatePanel>();

        if (levelData.Money >= dataOfUpdatePanel.RechargePrice)
        {
            DataOfGunPanel dataOfGunPanel = gameObject.GetComponent<DataOfUpdatePanel>().DataOfGunPanel;
            dataOfGunPanel.RechargeIndex++;

            PlayerData playerData = mainData.PlayersShip.GetComponent<PlayerData>();
            List<GameObject> gunList = playerData.TakeListOfGuns();

            levelData.Money -= dataOfUpdatePanel.RechargePrice;
            for (int i = 0; i < gunList.Count; i++)
            {
                DataOfGun gunData = gunList[i].GetComponent<DataOfGun>();
                if (gunData.TypeOfGun == dataOfGunPanel.ETypeOfGun)
                {
                    gunData.TimeRechargeIndex = dataOfGunPanel.RechargeIndex;
                    gunData.ReSetRecharge();
                }
            }
            SetDATA(dataOfGunPanel, gameObject.GetComponent<DataOfUpdatePanel>());
        }
    }
}
