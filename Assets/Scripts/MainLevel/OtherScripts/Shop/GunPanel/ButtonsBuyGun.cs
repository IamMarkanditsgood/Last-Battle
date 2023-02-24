using UnityEngine;

public class ButtonsBuyGun : MonoBehaviour
{
    [SerializeField] private MainDatas _mainDatasOfCanvas;
    [SerializeField] private DataWeaponsPanel _weaponPanelData;

    public void BuyInertialCannonGun()
    {
        Buy(ETypeOfGun.InertialArtillery);
    }
    public void BuyAimRocket()
    {
        Buy(ETypeOfGun.AimRocketGun);
    }
    public void BuyBasicRocketGun()
    {
        Buy(ETypeOfGun.BasicRocketGun);
    }
    public void BuyAutoGun()
    {
        Buy(ETypeOfGun.AutoGun);
    }
    public void BuyLaserGun()
    {
        Buy(ETypeOfGun.LaserGun);
    }
    public void BuyLightBallGun()
    {
        Buy(ETypeOfGun.LightBallGun);
    }
    public void BuyPlasmaGun()
    {
        Buy(ETypeOfGun.PlasmaGun);
    }
    public void BuyQuantumGun()
    {
        Buy(ETypeOfGun.QuantumGun);
    }
    public void BuyAlianAimRocketGun()
    {
        Buy(ETypeOfGun.AlianAimRocketGun);
    }
    public void BuyAlianLightBallGun()
    {
        Buy(ETypeOfGun.AlianLightBallGun);
    }
    public void BuyAlianBasicRocketGun()
    {
        Buy(ETypeOfGun.AlianBasicRocketGun);
    }

    private void Buy(ETypeOfGun eTypeOfGun)
    {
        FindDataClassPanel findDataClassPanel = new FindDataClassPanel();
        DataOfGunPanel dataOfGupPanel = findDataClassPanel.FindDataClass(eTypeOfGun, _weaponPanelData);
        if (LevelData.instance.Money > dataOfGupPanel.Price)
        {
            LevelData.instance.Money -= dataOfGupPanel.Price;
            dataOfGupPanel.IsBought = true;
            dataOfGupPanel.ButtonBuy.SetActive(false);
            dataOfGupPanel.ButtonUpdate.SetActive(true);
            dataOfGupPanel.ButtonInstall.SetActive(true);
        }
        else
        {
            print("You have not enought money!! And you shood finsih it");
        }
    }
    

}
