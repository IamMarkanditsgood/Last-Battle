using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShipData;
public class HealtheAndShieldController
{
    public void CheckHealtheAndShield(float healthe, float shield, GameObject ship, bool isPlayer)
    {
        if (isPlayer)
        {
            if (healthe <= 0)
            {
                Time.timeScale = 0;
                Object.Destroy(ship);
            }
        }
        else
        {
            if (healthe <= 0)
            {
                ship.SetActive(false);
            }
        }
    }
    public void TakeDamage(GameObject ship, float damage, bool isPlayer)
    {
        if (isPlayer)
        {
            PlayerData playerData = ship.GetComponent<PlayerData>();
            float healthe = playerData.Health;
            float shield = playerData.Shield;   
            if(shield > 0)
            {
                playerData.Shield -= damage;
            }
            else
            {
                playerData.Health -= damage;
            }

        }
        else
        {
            DataOfEnemies dataOfEnemy = ship.GetComponent<DataOfEnemies>();
            float healthe = dataOfEnemy.Healthe;
            float shield = dataOfEnemy.Shield;
            if (shield > 0)
            {
                dataOfEnemy.Shield -= damage;
            }
            else
            {
                dataOfEnemy.Healthe -= damage;
            }
        }
    }
    
}
