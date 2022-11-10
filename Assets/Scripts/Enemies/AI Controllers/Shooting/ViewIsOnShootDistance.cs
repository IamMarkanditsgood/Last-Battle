using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewIsOnShootDistance
{
    public void IsOnShootDistance(LayerMask enemyLayer, GameObject thisShip)
    {
        DataOfEnemies dataOfEnemy = thisShip.GetComponent<DataOfEnemies>();
        float distance = dataOfEnemy.DistanceForShooting;
        RaycastHit hit;
        if (Physics.Raycast(thisShip.transform.position, thisShip.transform.TransformDirection(Vector3.forward), out hit, distance, enemyLayer))
        {
            
            UseGans(ref thisShip);
        }
    }
    private void UseGans(ref GameObject thisShip)
    {
        
        DataOfEnemies dataOfEnemie = thisShip.GetComponent<DataOfEnemies>();
        List<GameObject> gunList = dataOfEnemie.GunList;
        for(int i=0; i < gunList.Count; i++)
        {
            if(gunList[i].activeInHierarchy)
            {
                ShootFromGun standardShoot = gunList[i].GetComponent<ShootFromGun>();
                standardShoot.Shoot();
            }
        }
    }
}
