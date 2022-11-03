using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindDataClassPanel : MonoBehaviour
{
    [SerializeField] private GameObject _dataObject;
    private MainDatas _mainDatasOfCanvas;

    private void Start()
    {
        _mainDatasOfCanvas = _dataObject.GetComponent<MainDatas>();
    }
    public DataOfGunPanel FindDataClass(ETypeOfGun eTypeOfGun)
    {
        for (int i = 0; i < _mainDatasOfCanvas.GunPanels.Count; i++)
        {
            if (_mainDatasOfCanvas.GunPanels[i].ETypeOfGun == eTypeOfGun)
            {
                return _mainDatasOfCanvas.GunPanels[i];
            }
        }
        print("Error!!: You have not this type of gun!");
        return null;
    }
}
