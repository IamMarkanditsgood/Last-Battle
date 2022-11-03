using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataOfEnemies : MonoBehaviour, IGanListOfShip
{
    [SerializeField] private List<GameObject> _listOfGun;
    [SerializeField] private EnemyData _scriptableObject;
    [SerializeField] private float _healthe;
    [SerializeField] private float _shield;
    [SerializeField] private float _reChargeTime;

    private void Start()
    {
        _healthe = _scriptableObject.Health;
        _shield = _scriptableObject.Shield;
        
    }
    private void OnEnable()
    {
        InstallReChangeTime();
    }
    private void InstallReChangeTime()
    {
       
        for (int i = 0; i < _listOfGun.Count; i++)
        {
            if (_listOfGun[i].activeInHierarchy)
            {
                DataOfGun dataOfGun = _listOfGun[i].GetComponent<DataOfGun>();
                _reChargeTime = dataOfGun.ReCharge;
            }
        }
    }
    public List<GameObject> TakeListOfGuns()
    {
        return _listOfGun;
    }
    public float RechargeTime
    {
        get { return _reChargeTime; }
        set { _reChargeTime = value; }
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
