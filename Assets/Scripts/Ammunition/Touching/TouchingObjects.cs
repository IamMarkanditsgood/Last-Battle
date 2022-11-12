using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchingObjects
{
    public void CheckingObjectLayer(Collider collision, GameObject bullet)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            CleanPrefab cleanPrefab = new CleanPrefab();
            DataOfProjectile dataOfProjectile = bullet.GetComponent<DataOfProjectile>();
            ControllerOfEnemyHealthe controllerOfHealthe = new ControllerOfEnemyHealthe();
            float damage = dataOfProjectile.Damage * dataOfProjectile.DamageIndex;
            DataOfEnemies dataOfEnemies = collision.gameObject.GetComponent<DataOfEnemies>();
            controllerOfHealthe.TakeDamage(damage, dataOfEnemies);
            cleanPrefab.DeleteParticle(dataOfProjectile);
            bullet.SetActive(false);

        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Meteorite"))
        {
            CleanPrefab cleanPrefab = new CleanPrefab();
            DataOfProjectile dataOfProjectile = bullet.GetComponent<DataOfProjectile>();
            cleanPrefab.DeleteParticle(dataOfProjectile);
            bullet.SetActive(false);
        }
    }
}
