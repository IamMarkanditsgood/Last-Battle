using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ShipData;

public class UpdatePanelController : MonoBehaviour
{
    [SerializeField] private MainDatas _mainData;

    private SoundsController _soundsController = new SoundsController();

    public void SetDATA(DataOfGunPanel gunPanelData,  DataOfUpdatePanel dataOfUpdatePanel)
    {
        dataOfUpdatePanel.Name = gunPanelData.ETypeOfGun.ToString();

        dataOfUpdatePanel.DamageIndex = gunPanelData.DamageIndex;
        dataOfUpdatePanel.DamagePrice = dataOfUpdatePanel.FirstPrices * dataOfUpdatePanel.DamageIndex;

        dataOfUpdatePanel.RechargeIndex = gunPanelData.RechargeIndex;
        dataOfUpdatePanel.RechargePrice = dataOfUpdatePanel.FirstPrices * dataOfUpdatePanel.RechargeIndex;

        dataOfUpdatePanel.CanUpdateDamage = gunPanelData.CanUpdateDamage;
        dataOfUpdatePanel.CanUpdateRecharge = gunPanelData.CanUpdateRecharge;
       
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
        _soundsController.UseSound(ETypeOfSound.ButtonSound);
        LevelData levelData = LevelData.instance;
        DataOfUpdatePanel dataOfUpdatePanel = GetComponent<DataOfUpdatePanel>();
        if(dataOfUpdatePanel.CanUpdateDamage)
        {
            if (levelData.Money >= dataOfUpdatePanel.DamagePrice)
            {
                DataOfGunPanel dataOfGunPanel = gameObject.GetComponent<DataOfUpdatePanel>().DataOfGunPanel;

                dataOfGunPanel.DamageIndex++;
                levelData.Money -= dataOfUpdatePanel.DamagePrice;

                UpdateDamageOfGuns(dataOfGunPanel);
                SetDATA(dataOfGunPanel, gameObject.GetComponent<DataOfUpdatePanel>());
            }
            else
            {
                ActivateErrorMessageMoney();
            }
        }
        else
        {
            ActivateErrorMessageLimit();
        }
    }
    public void AddRecharge()
    {
        _soundsController.UseSound(ETypeOfSound.ButtonSound);
        LevelData levelData = LevelData.instance;
        DataOfUpdatePanel dataOfUpdatePanel = GetComponent<DataOfUpdatePanel>();
        if (dataOfUpdatePanel.CanUpdateRecharge)
        {
            if (levelData.Money >= dataOfUpdatePanel.RechargePrice)
            {
                DataOfGunPanel dataOfGunPanel = gameObject.GetComponent<DataOfUpdatePanel>().DataOfGunPanel;

                levelData.Money -= dataOfUpdatePanel.RechargePrice;
                dataOfGunPanel.RechargeIndex++;

                UpdateRechargeOfGuns(dataOfGunPanel);
                SetDATA(dataOfGunPanel, gameObject.GetComponent<DataOfUpdatePanel>());
            }
            else
            {
                ActivateErrorMessageMoney();
            }
        }
        else
        {
            ActivateErrorMessageLimit();
        }
    }

    private void UpdateDamageOfGuns(DataOfGunPanel dataOfGunPanel)
    {
        PlayerData playerData = _mainData.PlayersShip.GetComponent<PlayerData>();
        List<GameObject> gunList = playerData.TakeListOfGuns();

        for (int i = 0; i < gunList.Count; i++)
        {
            DataOfGun gunData = gunList[i].GetComponent<DataOfGun>();
            float futureDamage = gunData.FirstDamage * (gunData.DamageIndex + 1);
            float maxDamage = 0;

            if (gunData.TypeOfGun == dataOfGunPanel.ETypeOfGun)
            {
                maxDamage = gunData.MaxDamage;
                gunData.DamageIndex = dataOfGunPanel.DamageIndex;
                gunData.ReSetDamage();
                if (maxDamage <= futureDamage)
                {
                    dataOfGunPanel.CanUpdateDamage = false;
                }
            }
        }
    }
    private void UpdateRechargeOfGuns(DataOfGunPanel dataOfGunPanel)
    {
        PlayerData playerData = _mainData.PlayersShip.GetComponent<PlayerData>();
        List<GameObject> gunList = playerData.TakeListOfGuns();

        for (int i = 0; i < gunList.Count; i++)
        {
            DataOfGun gunData = gunList[i].GetComponent<DataOfGun>();
            float futureRecharge = gunData.FirstRechargeTime / ((gunData.TimeRechargeIndex + 1) / 2);
            float minTimeOfRecharge = 0;
            if (gunData.TypeOfGun == dataOfGunPanel.ETypeOfGun)
            {
                minTimeOfRecharge = gunData.MinTimeOfRecharge;
                gunData.TimeRechargeIndex = dataOfGunPanel.RechargeIndex;
                gunData.ReSetRecharge();

                if (minTimeOfRecharge >= futureRecharge)
                {
                    dataOfGunPanel.CanUpdateRecharge = false;
                }
            }

        }
    }
    private void ActivateErrorMessageLimit()
    {
        GameObject messagePanel = _mainData.MessagePanel.GetComponent<MessagePanelData>().EnhancementLimitReached;
        messagePanel.SetActive(true);
    }
    private void ActivateErrorMessageMoney()
    {
        GameObject messagePanel = _mainData.MessagePanel.GetComponent<MessagePanelData>().NotEnoughMoneyPanel;
        messagePanel.SetActive(true);
    }
}
