using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindDataClassPanel
{
    public DataOfGunPanel FindDataClass(ETypeOfGun eTypeOfGun, DataWeaponsPanel _dataWeaponsPanel)
    {
        for (int i = 0; i < _dataWeaponsPanel.GunPanels.Count; i++)
        {
            if (_dataWeaponsPanel.GunPanels[i].ETypeOfGun == eTypeOfGun)
            {
                return _dataWeaponsPanel.GunPanels[i];
            }
        }
        Debug.Log("Error!!: You have not this type of gun!");
        return null;
    }
}
