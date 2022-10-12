using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataOfProjectile : MonoBehaviour
{ 
    [SerializeField] private AmmunitionData scriptableObjects;
    private float _damageIndex = 2;
    private float _speedIndex = 1;
    public float DamageIndex
    {
        get { return _damageIndex; }
        set { _damageIndex = value; }
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
}
