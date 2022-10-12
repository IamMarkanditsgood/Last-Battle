using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerOfHealthe : MonoBehaviour
{

    public void TakeDamage(float damage)
    {
        DataOfEnemies _dataOfEnemies = GetComponent<DataOfEnemies>();
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
