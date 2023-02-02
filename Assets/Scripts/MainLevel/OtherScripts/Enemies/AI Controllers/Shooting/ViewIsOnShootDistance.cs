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
            
            UseGans(ref thisShip);
        }
    }
    private void UseGans(ref GameObject thisShip)
    {
        List<GameObject> list = new List<GameObject>();
        list.Add(LevelData.instance.Player);
        thisShip.GetComponent<IGetListOfEnemy>().SetEnemyOfThisShip(list);
        DataOfEnemies dataOfEnemie = thisShip.GetComponent<DataOfEnemies>();
        List<GameObject> gunList = dataOfEnemie.GunList;
        for(int i=0; i < gunList.Count; i++)
        {
            if(gunList[i].activeInHierarchy)
            {
                IStandardShoot standardShoot = gunList[i].GetComponent<IStandardShoot>();
                standardShoot.Shoot();
            }
        }
    }
}
