using ShipData;
using System.Collections.Generic;
using UnityEngine;

public class ShootFromGun // Можливо поміняти
{
    public void ShootPlayerGuns(PlayerData playerData)
    {
        playerData.SetEnemyOfThisShip(LevelData.instance.ListOfEnemiesOnScene);

        List<GameObject> listOfGuns = playerData.TakeListOfGuns();
        for (int i = 0; i < listOfGuns.Count; i++)
        {
            if (listOfGuns[i].activeInHierarchy)
            {
                GameObject obj = listOfGuns[i];
                IStandardShoot shooting = obj.GetComponent<IStandardShoot>();
                shooting.Shoot();
            }
        }
    }
    public void ShootEnemyGun(DataOfEnemies dataOfEnemy)
    {
        List<GameObject> gunList = dataOfEnemy.GunList;

        for (int i = 0; i < gunList.Count; i++)
        {
            if (gunList[i].activeInHierarchy)
            {
                IStandardShoot standardShoot = gunList[i].GetComponent<IStandardShoot>();
                standardShoot.Shoot();
            }
        }
    }
}
