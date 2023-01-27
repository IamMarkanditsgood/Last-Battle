using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsUpdateGun : MonoBehaviour
{
    //[SerializeField] private GameObject _mainDataObject;
    [SerializeField] private UpdatePanelController _updatePanelController;
    [SerializeField] private MainDatas mainData;
    [SerializeField] private DataWeaponsPanel weaponsPanelData;
    /*private void Start()
    {
        mainData = _mainDataObject.GetComponent<MainDatas>();
    }*/
    public void UpdateInertialCannonGun()
    {
        SwitchOnUpdatePanel(ETypeOfGun.InertialArtillery);
    }
    public void UpdateAimRocket()
    {
        SwitchOnUpdatePanel(ETypeOfGun.AimRocketGun);
    }
    public void UpdateBasicRocketGun()
    {
        SwitchOnUpdatePanel(ETypeOfGun.BasicRocketGun);
    }
    public void UpdateAutoGun()
    {
        SwitchOnUpdatePanel(ETypeOfGun.AutoGun);
    }
    public void UpdateLaserGun()
    {
        SwitchOnUpdatePanel(ETypeOfGun.LaserGun);
    }
    public void UpdateLightBallGun()
    {
        SwitchOnUpdatePanel(ETypeOfGun.LightBallGun);
    }
    public void UpdatePlasmaGun()
    {
        SwitchOnUpdatePanel(ETypeOfGun.PlasmaGun);
    }
    public void UpdateQuantumGun()
    {
        SwitchOnUpdatePanel(ETypeOfGun.QuantumGun);
    }
    public void UpdateAlianAimRocketGun()
    {
        SwitchOnUpdatePanel(ETypeOfGun.AlianAimRocketGun);
    }
    public void UpdateAlianLightBallGun()
    {
        SwitchOnUpdatePanel(ETypeOfGun.AlianLightBallGun);
    }
    public void UpdateAlianBasicRocketGun()
    {
        SwitchOnUpdatePanel(ETypeOfGun.AlianBasicRocketGun);
    }
    private void SwitchOnUpdatePanel(ETypeOfGun eTypeOfGun)
    {
        
        DataOfUpdatePanel dataOfUpdatePanel = mainData.UpdateGunPanel.GetComponent<DataOfUpdatePanel>();
        FindDataClassPanel findDataClassPanel = new FindDataClassPanel();
        DataOfGunPanel dataOfGunPanel = findDataClassPanel.FindDataClass(eTypeOfGun, weaponsPanelData);
        mainData.UpdateGunPanel.GetComponent<DataOfUpdatePanel>().DataOfGunPanel = dataOfGunPanel;
        dataOfUpdatePanel.FirstPrices = dataOfGunPanel.FirstUpdatePrice;
        mainData.UpdateGunPanel.SetActive(true);
        _updatePanelController.SetDATA(dataOfGunPanel, dataOfUpdatePanel);
    }
}
