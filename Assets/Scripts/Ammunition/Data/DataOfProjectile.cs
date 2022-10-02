using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataOfProjectile : MonoBehaviour
{ 
    [SerializeField] private AmmunitionData scriptableObjects;
    public AmmunitionData ScriptableObjects
    {
        get { return scriptableObjects; }
        set { scriptableObjects = value; }
    }
}
