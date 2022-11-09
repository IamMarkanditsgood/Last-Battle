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
            ControllerOfHealthe controllerOfHealthe = collision.gameObject.GetComponent<ControllerOfHealthe>();
            float damage = bullet.GetComponent<DataOfProjectile>().ScriptableObjects.Damage * dataOfProjectile.DamageIndex;
            controllerOfHealthe.TakeDamage(damage);
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
