using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UpdatePanelController : MonoBehaviour
{
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
        DataOfGunPanel dataOfGunPanel = gameObject.GetComponent<DataOfUpdatePanel>().DataOfGunPanel;
        dataOfGunPanel.DamageIndex++;
        SetDATA(dataOfGunPanel, gameObject.GetComponent<DataOfUpdatePanel>());
    }
    public void AddRecharge()
    {
        DataOfGunPanel dataOfGunPanel = gameObject.GetComponent<DataOfUpdatePanel>().DataOfGunPanel;
        dataOfGunPanel.RechargeIndex++;
        SetDATA(dataOfGunPanel, gameObject.GetComponent<DataOfUpdatePanel>());
    }
}
