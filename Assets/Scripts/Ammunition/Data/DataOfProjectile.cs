using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataOfProjectile : MonoBehaviour
{
    [SerializeField] private AmmunitionData scriptableObjects;
    private GameObject _currentParticles;
    private float _damageIndex = 1;
    private float _damage;
    private float _speedIndex = 1;
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
    public AmmunitionData ScriptableObjects
    {
        get { return scriptableObjects; }
        set { scriptableObjects = value; }
    }
    public GameObject CurrentParticles
    {
        get { return _currentParticles; }
        set { _currentParticles = value;  }
    }
}
