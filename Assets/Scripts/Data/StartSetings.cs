using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSetings : MonoBehaviour
{
    public static StartSetings instance;
    [SerializeField] private float _xLevelSize;
    [SerializeField] private float _zLevelSize;
    [SerializeField] private int _numberOfMeteorites;
    [SerializeField] private int _numberOfProjectiles;
    private void Awake()
    {
        instance = this;
    }
    public float XLevelSize
    {
        get { return _xLevelSize; }
        set { _xLevelSize = value; }
    }
    public float ZLevelSize
    {
        get { return _zLevelSize; }
        set { _zLevelSize = value; }
    }
    public int NumberOfMeteorites
    {
        get { return _numberOfMeteorites; }
        set { _numberOfMeteorites = value; }
    }
    public int NumberOfProjectile
    {
        get { return _numberOfProjectiles; }
        set { _numberOfProjectiles = value; }
    }

}
