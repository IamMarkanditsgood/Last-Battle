using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerOfHealthe : MonoBehaviour
{
    [SerializeField] private GameObject _particlesForDeath;
    private DataOfEnemies _dataOfEnemies;
    private void Start()
    {
        _dataOfEnemies = GetComponent<DataOfEnemies>();
    }
    private void Update()
    {
        if(_dataOfEnemies.Healthe <= 0)
        {
            Instantiate(_particlesForDeath, gameObject.transform);
            Destroy(gameObject);
        }
    }
    public void TakeDamage(float damage)
    {
        
        if (_dataOfEnemies.Shield <= 0)
        {
            _dataOfEnemies.Healthe -= damage;
            print("Healthe" + _dataOfEnemies.Healthe);
        }
        else
        {
            _dataOfEnemies.Shield -= damage;
            print("Shield" + _dataOfEnemies.Shield);
        }
        
    }
}
