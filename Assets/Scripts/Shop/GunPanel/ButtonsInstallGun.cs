using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShipData;

public class ButtonsInstallGun : MonoBehaviour
{
    [SerializeField] private GameObject _dataObject;
    
    private MainDatas _mainDatasOfCanvas;

    private void Start()
    {
        _mainDatasOfCanvas = _dataObject.GetComponent<MainDatas>();
    }
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
    private void Install(ETypeOfGun eTypeOfGun)
    {
        FindDataClassPanel findDataClassPanel = GetComponent<FindDataClassPanel>();
        DataOfGunPanel dataOfGupPanel = findDataClassPanel.FindDataClass(eTypeOfGun);
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
        List<DataOfGunPanel> listOfGunPanels = _mainDatasOfCanvas.GunPanels;
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
