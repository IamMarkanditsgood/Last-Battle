using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewIsOnShootDistance
{
    public void IsOnShootDistance(LayerMask enemyLayer, GameObject thisShip, float distance)
    {
        RaycastHit hit;
        if (Physics.Raycast(thisShip.transform.position, thisShip.transform.TransformDirection(Vector3.forward), out hit, distance, enemyLayer))
        {
            ShootFromGun shootFromGun = new ShootFromGun();
            DataOfEnemies dataOfEnemies = thisShip.GetComponent<DataOfEnemies>();

            SetEnemyForThisShip(ref thisShip);
            shootFromGun.ShootEnemyGun(dataOfEnemies);
        }
    }
    private void SetEnemyForThisShip(ref GameObject thisShip)
    {
        List<GameObject> list = new List<GameObject>();
        list.Add(LevelData.instance.Player);
        thisShip.GetComponent<IGetListOfEnemy>().SetEnemyOfThisShip(list);
    }
}
