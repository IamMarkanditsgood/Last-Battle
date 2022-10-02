using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabsStorey : MonoBehaviour
{
    public static PrefabsStorey instance;
    [SerializeField] private List<GameObject> _meteorites = new List<GameObject>();
    [SerializeField] private GameObject _projectile;

    private void Awake()
    {
        instance = this;
    }
    public List<GameObject> Meteorites
    {
        get { return _meteorites; }
    }
    public GameObject Projectile
    { 
        get { return _projectile; } 
    }


}
