using UnityEngine;
using ShipData;

public class HealtheAndShieldController
{
    public bool CheckHealtheAndShield(float healthe)
    {
        if (healthe <= 0)
        {
            return false;
        }
        return true;
    }

    public void TakeDamage(GameObject ship, float damage, bool isPlayer)
    {
        if (isPlayer)
        {
            PlayerData playerData = ship.GetComponent<PlayerData>();
            float shield = playerData.GetShield();   
            if(shield > 0)
            {
                playerData.SetShield(playerData.GetShield() - damage);
            }
            else
            {
                playerData.SetHealth( playerData.GetHealth() - damage);
            }

        }
        else
        {
            DataOfEnemies dataOfEnemy = ship.GetComponent<DataOfEnemies>();

            float shield = dataOfEnemy.GetShield();

            if (shield > 0)
            {
                dataOfEnemy.SetShield(dataOfEnemy.GetShield() - damage);
            }
            else
            {
                dataOfEnemy.SetHealth(dataOfEnemy.GetHealth() - damage);
            }
        }
    }
    
}
