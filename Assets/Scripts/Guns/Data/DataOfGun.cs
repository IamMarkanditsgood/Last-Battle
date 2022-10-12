using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataOfGun : MonoBehaviour
{
    [SerializeField] private ETypeOfGun _typeOfGun;
    [SerializeField] private Transform _positionsForShooting;
    [SerializeField] private AmmunitionData _scriptableObject;
    [SerializeField] private float _damageIndex;
    [SerializeField] private float _speedIndex;


    public float DamageIndex
    {
        get { return _damageIndex; }
        set { _damageIndex = value; }
    }
    public float SpeedIndex
    {
        get { return _speedIndex; }
        set { _speedIndex = value; }
    }
    public ETypeOfGun TypeOfGun
    {
        get { return _typeOfGun; }
    }
    public Transform PositionForSooting
    {
        get { return _positionsForShooting; }
    }
    public AmmunitionData ScriptableObject
    {
        get { return _scriptableObject; }
    }
}
