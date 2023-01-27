using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataOfGun : MonoBehaviour
{
    [SerializeField] private ETypeOfGun _typeOfGun;
    [SerializeField] private ETypeOfSound _typeOfSound;
    [SerializeField] private Transform _positionsForShooting;
    [SerializeField] private AmmunitionData _bullet;
    [SerializeField] private List<GameObject> _particleObjects;
    [SerializeField] private float _damageIndex;
    [SerializeField] private float _damage;
    [SerializeField] private float _firstDamage;
    [SerializeField] private float _timeRechargeIndex;
    [SerializeField] private float _recharge;
    [SerializeField] private float _firstRechargeTime;
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
    public ETypeOfGun TypeOfGun
    {
        get { return _typeOfGun; }
    }
    public ETypeOfSound TypeOfSound { get { return _typeOfSound; } }
    public List<GameObject> ParticleList { get { return _particleObjects; } }
    public GameObject GetParticleObject(ETypeOfEffect eTypeOfEffect)
    {
        for (int i = 0; i < _particleObjects.Count; i++)
        {
            
            if (_particleObjects[i].GetComponent<EffectObjData>().TypeOfEffect == eTypeOfEffect)
            {            
                return _particleObjects[i];
            }

        }
        print("Error: You have not this Effect in data of enemy! or you do not need it");
        return null;
    }
    public Transform PositionForSooting
    {
        get { return _positionsForShooting; }
    }
    public AmmunitionData Bullet
    {
        get { return _bullet; }
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
