using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShipData;

public class ButtonsInstallGun : MonoBehaviour
{
    //[SerializeField] private GameObject _dataObject;
    [SerializeField] private DataWeaponsPanel _dataWeaponsPanel;
    [SerializeField] private MainDatas _mainDatasOfCanvas;

    /*private void Start()
    {
        _mainDatasOfCanvas = _dataObject.GetComponent<MainDatas>();
    }*/
    public void InstallInertialCannonGun()
    {
        Install(ETypeOfGun.InertialArtillery);
    }
    public void InstallAimRocket()
    {
        Install(ETypeOfGun.AimRocketGun);
    }
    public void InstallBasicRocketGun()
    {
        Install(ETypeOfGun.BasicRocketGun);
    }
    public void InstallAutoGun()
    {
        Install(ETypeOfGun.AutoGun);
    }
    public void InstallLaserGun()
    {
        Install(ETypeOfGun.LaserGun);
    }
    public void InstallLightBallGun()
    {
        Install(ETypeOfGun.LightBallGun);
    }
    public void InstallPlasmaGun()
    {
        Install(ETypeOfGun.PlasmaGun);
    }
    public void InstallQuantumGun()
    {
        Install(ETypeOfGun.QuantumGun);
    }
    public void InstallAlianAimRocketGun()
    {
        Install(ETypeOfGun.AlianAimRocketGun);
    }
    public void InstallAlianLightBallGun()
    {
        Install(ETypeOfGun.AlianLightBallGun);
    }
    public void InstallAlianBasicRocketGun()
    {
        Install(ETypeOfGun.AlianBasicRocketGun);
    }
    private void Install(ETypeOfGun eTypeOfGun)
    {
        FindDataClassPanel findDataClassPanel = new FindDataClassPanel();
        DataOfGunPanel dataOfGupPanel = findDataClassPanel.FindDataClass(eTypeOfGun, _dataWeaponsPanel);
        dataOfGupPanel.IsInstall = true;
        dataOfGupPanel.ButtonInstall.SetActive(false);
        dataOfGupPanel.ButtonInstalled.SetActive(true);
        ChangeButtons(eTypeOfGun);
        ChangeGunOnShip(eTypeOfGun);
    }
    private void ChangeGunOnShip(ETypeOfGun eTypeOfGun)
    {
        GameObject ship = _mainDatasOfCanvas.PlayersShip;
        PlayerData playerData = ship.GetComponent<PlayerData>();
        List<GameObject> listOfGuns = playerData.TakeListOfGuns();
        for (int i = 0; i < listOfGuns.Count; i++)
        {
            DataOfGun dataOfGun = listOfGuns[i].GetComponent<DataOfGun>();
            if(dataOfGun.TypeOfGun == eTypeOfGun)
            {
                listOfGuns[i].SetActive(true);
            }
            else
            {
                listOfGuns[i].SetActive(false);
            }
        }
    }
    private void ChangeButtons(ETypeOfGun eTypeOfGun)
    {
        List<DataOfGunPanel> listOfGunPanels = _dataWeaponsPanel.GunPanels;
        for (int i = 0; i < listOfGunPanels.Count; i++)
        {
            if (listOfGunPanels[i].ETypeOfGun != eTypeOfGun && listOfGunPanels[i].IsBought)
            {
                listOfGunPanels[i].ButtonInstall.SetActive(true);
                listOfGunPanels[i].ButtonInstalled.SetActive(false);
                listOfGunPanels[i].IsInstall = false;
            }
        }
    }
   
}
