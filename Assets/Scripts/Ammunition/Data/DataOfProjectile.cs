using UnityEngine;

public class DataOfProjectile : MonoBehaviour
{
    [SerializeField] private AmmunitionData scriptableObjects;

    private GameObject _currentTurget;
    private GameObject _currentParticles;
    private GameObject _ownersShip;

    private float _damageIndex = 1;
    private float _damage;
    private float _speedIndex = 1;

    public AmmunitionData ScriptableObjects
    {
        get { return scriptableObjects; }
        set { scriptableObjects = value; }
    }

    public GameObject CurrentParticles
    {
        get { return _currentParticles; }
        set { _currentParticles = value; }
    }
    public GameObject OwnersShip
    {
        get { return _ownersShip; }
        set { _ownersShip = value; }
    }
    public GameObject CurrentTarget
    {
        get { return _currentTurget; }
        set { _currentTurget = value; }
    }

    public float DamageIndex
    {
        get { return _damageIndex; }
        set { _damageIndex = value; }
    }
    public float Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }
    public float speedIndex
    {
        get { return _speedIndex; }
        set { _speedIndex = value; }
    }
    
}
