using UnityEngine;

public class DataOfGun : MonoBehaviour
{
    [SerializeField] private AmmunitionData _bullet;

    [SerializeField] private ETypeOfGun _typeOfGun;
    [SerializeField] private ETypeOfSound _typeOfSound;
    [SerializeField] private ETypeOfEffect _typeOfShotEffect;

    [SerializeField] private GameObject _gunOwner;

    [SerializeField] private Transform _positionsForShooting;

    [SerializeField] private float _damageIndex;
    [SerializeField] private float _damage;
    [SerializeField] private float _firstDamage;
    [SerializeField] private float _timeRechargeIndex;
    [SerializeField] private float _recharge;
    [SerializeField] private float _firstRechargeTime;
    [SerializeField] private float _minTimeOfRecharge;

    private bool _isCharged = true;

    private void OnEnable()
    {
        SetDamageAndRecharge();
    }

    public AmmunitionData Bullet
    {
        get { return _bullet; }
    }

    public ETypeOfGun TypeOfGun { get { return _typeOfGun; } }
    public ETypeOfSound TypeOfSound { get { return _typeOfSound; } }
    public ETypeOfEffect TypeOfShotEffect { get { return _typeOfShotEffect; } }

    public GameObject GunOwner
    {
        get { return _gunOwner; }
    }

    public Transform PositionForSooting
    {
        get { return _positionsForShooting; }
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
    public float MinTimeOfRecharge
    {
        get { return _minTimeOfRecharge; }
        set { _minTimeOfRecharge = value; }
    }

    public bool IsCharged
    {
        get { return _isCharged; }
        set { _isCharged = value; }
    }

    public void ReSetDamage()
    {
        _damage = _firstDamage * _damageIndex;
    }
    public void ReSetRecharge()
    {
        _recharge = _firstRechargeTime / (_timeRechargeIndex / 2);
    }

    public void SetDamageAndRecharge()
    {
        
        _damage = _firstDamage * _damageIndex;
        _recharge = _firstRechargeTime / (_timeRechargeIndex / 2); 
    }
}
