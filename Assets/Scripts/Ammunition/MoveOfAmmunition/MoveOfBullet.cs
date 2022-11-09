using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOfBullet : IProjectileMover
{
    public void MoveProjectile(GameObject projectile)
    {
        
        DataOfProjectile dataOfProjectile = projectile.GetComponent<DataOfProjectile>();
        float speed = dataOfProjectile.ScriptableObjects.Speed;
        projectile.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
