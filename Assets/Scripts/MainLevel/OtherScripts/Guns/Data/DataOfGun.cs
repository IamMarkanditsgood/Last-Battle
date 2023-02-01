using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataOfGun : MonoBehaviour
{
    [SerializeField] private ETypeOfGun _typeOfGun;
    [SerializeField] private ETypeOfSound _typeOfSound;
    [SerializeField] private ETypeOfEffect _typeOfShotEffect;
    [SerializeField] private Transform _positionsForShooting;
    [SerializeField] private AmmunitionData _bullet;
    [SerializeField] private float _damageIndex;
    [SerializeField] private float _damage;
    [SerializeField] private float _firstDamage;
    [SerializeField] private float _timeRechargeIndex;
    [SerializeField] private float _recharge;
    [SerializeField] private float _firstRechargeTime;
    [SerializeField] private GameObject _gunOwner;
    private bool _isCharged = true;

    private void OnEnable()
    {
        _damage = _firstDamage * _damageIndex;
        _recharge = _firstRechargeTime / (_timeRechargeIndex/2);
    }
    public bool IsCharged
    {
        get { return _isCharged; }
        set { _isCharged = value; }
    }
    public float Damage
    {
        get { return _damage; }
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
        get { return _recharge; }    }
    public ETypeOfGun TypeOfGun{ get { return _typeOfGun; }}
    public ETypeOfSound TypeOfSound { get { return _typeOfSound; } }
    public ETypeOfEffect TypeOfShotEffect { get { return _typeOfShotEffect; } }
    public Transform PositionForSooting
    {
        get { return _positionsForShooting; }
    }
    public AmmunitionData Bullet
    {
        get { return _bullet; }
    }
    public GameObject GunOwner
    {
        get { return _gunOwner; }
    }
    public void ReSetDamage()
    {
        _damage = _firstDamage * _damageIndex;
        
    }
    public void ReSetRecharge()
    {
        _recharge = _firstRechargeTime / (_timeRechargeIndex / 2);
    }
}
