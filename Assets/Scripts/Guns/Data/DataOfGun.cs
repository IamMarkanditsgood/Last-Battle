using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataOfGun : MonoBehaviour
{
    [SerializeField] private ETypeOfGun _typeOfGun;
    [SerializeField] private Transform _positionsForShooting;
    [SerializeField] private AmmunitionData _bullet;
    [SerializeField] private float _damageIndex;
    [SerializeField] private float _timeRechargeIndex;
    [SerializeField] private float _recharge;
    private bool _isCharged = true;

    public bool IsCharged
    {
        get { return _isCharged; }
        set { _isCharged = value; }
    }
    public float DamageIndex
    {
        get { return _damageIndex; }
        set { _damageIndex = value; }
    }
    public float TimeRechargeIndex
    {
        get { return _timeRechargeIndex; }
        set { _timeRechargeIndex = value; }
    }
    public float ReCharge
    {
        get { return _recharge / _timeRechargeIndex; }
        set { _recharge = value; }
    }
    public ETypeOfGun TypeOfGun
    {
        get { return _typeOfGun; }
    }
    public Transform PositionForSooting
    {
        get { return _positionsForShooting; }
    }
    public AmmunitionData Bullet
    {
        get { return _bullet; }
    }
}
