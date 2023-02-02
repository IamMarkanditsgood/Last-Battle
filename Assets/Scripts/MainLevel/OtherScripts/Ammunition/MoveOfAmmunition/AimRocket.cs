using ShipData;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AimRocket : IProjectileMover
{
    public void MoveProjectile(GameObject projectile)
    {
        DataOfProjectile dataOfProjectile = projectile.GetComponent<DataOfProjectile>();
        if (dataOfProjectile.OwnersShip.GetComponent<IGetListOfEnemy>().GetEnemyOfThisShip().Count != 0)
        {
            GameObject targetObj = GetTarget(projectile, dataOfProjectile);
            projectile.transform.LookAt(targetObj.transform, Vector3.up);
            float speed = dataOfProjectile.ScriptableObjects.Speed;
            projectile.transform.Translate(Vector3.forward * speed * Time.deltaTime);// Change on ADDForce
        }
        else
        {
            MoveOfBullet moveOfBullet = new MoveOfBullet();
            moveOfBullet.MoveProjectile(projectile);
        }
    }
    private GameObject GetTarget(GameObject projectile, DataOfProjectile dataOfProjectile)
    {
        

        List<GameObject> targets = dataOfProjectile.OwnersShip.GetComponent<IGetListOfEnemy>().GetEnemyOfThisShip();
        float currentMinDistance = Vector3.Distance(projectile.transform.position, targets[0].transform.position);
        int indexOfNearestTarget = 0;
        for (int i = 0; i < targets.Count ; i++)
        {   
            float checkedDistance = Vector3.Distance(projectile.transform.position, targets[i].transform.position);
            if (checkedDistance < currentMinDistance)
            {
                currentMinDistance= checkedDistance;
                indexOfNearestTarget = i;
            }
        }
        return targets[indexOfNearestTarget];
    }

}
