using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsUpdateGun : MonoBehaviour
{
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
    private void SwitchOnUpdatePanel(ETypeOfGun eTypeOfGun)
    {
        FindDataClassPanel findDataClassPanel = GetComponent<FindDataClassPanel>();
        DataOfGunPanel dataOfGupPanel = findDataClassPanel.FindDataClass(eTypeOfGun);
        dataOfGupPanel.UpdatePanel.SetActive(true);
    }
}
