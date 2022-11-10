using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerOfEnemyHealthe
{

    public void ShouldDie(GameObject enemy,DataOfEnemies dataOfEnemies)
    {
        if(dataOfEnemies.Healthe <= 0)
        {
            Object.Destroy(enemy);
        }
    }
    public void TakeDamage(float damage, DataOfEnemies dataOfEnemies)
    {
        
        if (dataOfEnemies.Shield <= 0)
        {
            dataOfEnemies.Healthe -= damage;
            Debug.Log("Healthe" + dataOfEnemies.Healthe);
        }
        else
        {
            dataOfEnemies.Shield -= damage;
            Debug.Log("Shield" + dataOfEnemies.Shield);
        }
        
    }
}
