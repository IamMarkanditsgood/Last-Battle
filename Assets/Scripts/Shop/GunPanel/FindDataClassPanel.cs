using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindDataClassPanel
{

    private MainDatas _mainDatasOfCanvas;

    public DataOfGunPanel FindDataClass(ETypeOfGun eTypeOfGun, MainDatas _mainDatasOfCanvas)
    {
        for (int i = 0; i < _mainDatasOfCanvas.GunPanels.Count; i++)
        {
            if (_mainDatasOfCanvas.GunPanels[i].ETypeOfGun == eTypeOfGun)
            {
                return _mainDatasOfCanvas.GunPanels[i];
            }
        }
        Debug.Log("Error!!: You have not this type of gun!");
        return null;
    }
}
