using ShipData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimRocket : IProjectileMover
{
    public void MoveProjectile(GameObject projectile)
    {
        LevelData levelData = LevelData.instance;
        //GameObject targetObj = GetTarget(levelData, projectile);
        //Debug.Log(targetObj);
        //projectile.transform.LookAt(targetObj.transform, Vector3.up);
        DataOfProjectile dataOfProjectile = projectile.GetComponent<DataOfProjectile>();
        float speed = dataOfProjectile.ScriptableObjects.Speed;
        projectile.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

}
