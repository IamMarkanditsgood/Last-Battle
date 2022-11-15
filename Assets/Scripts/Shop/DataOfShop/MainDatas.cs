using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDatas : MonoBehaviour
{
    [SerializeField] private GameObject _playersShip;
    [SerializeField] private GameObject _updateGunPanel;
    [SerializeField] private List<DataOfGunPanel> _gunPanels;

    public GameObject PlayersShip{ get { return _playersShip; } }
    public GameObject UpdateGunPanel { get { return _updateGunPanel; } }
    public List<DataOfGunPanel> GunPanels
    {
        get { return _gunPanels; }
    }
}
