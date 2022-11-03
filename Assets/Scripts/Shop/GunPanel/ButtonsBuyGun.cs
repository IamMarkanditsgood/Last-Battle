using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsBuyGun : MonoBehaviour
{
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
    private void Buy(ETypeOfGun eTypeOfGun)
    {
        FindDataClassPanel findDataClassPanel = GetComponent<FindDataClassPanel>();
        DataOfGunPanel dataOfGupPanel = findDataClassPanel.FindDataClass(eTypeOfGun);
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
