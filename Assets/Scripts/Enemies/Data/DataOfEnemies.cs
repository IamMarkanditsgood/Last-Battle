using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataOfEnemies : MonoBehaviour
{
    [SerializeField] private List<GameObject> _listOfGun;
    [SerializeField] private EnemyData _scriptableObject;
    [SerializeField] private float _healthe;
    [SerializeField] private float _shield;

    private void Start()
    {
        _healthe = _scriptableObject.Health;
        _shield = _scriptableObject.Shield;
    }
    public float Healthe
    {
        get { return _healthe; }
        set { _healthe = value; }
    }
    public float Shield
    {
        get { return _shield; }
        set { _shield = value; }
    }

    public List<GameObject> GunList
    {
        get { return _listOfGun; }
    }
    public EnemyData ScriptableObjectOfEnemy
    {
        get { return _scriptableObject; }
        set { _scriptableObject = value; }
    }
}
