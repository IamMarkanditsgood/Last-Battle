using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchingObjects
{
    public void CheckingObjectLayer(Collider collision, GameObject bullet)
    {

        if (collision.gameObject.layer == LayerMask.NameToLayer("Meteorite"))
        {
            CleanPrefab cleanPrefab = new CleanPrefab();
            DataOfProjectile dataOfProjectile = bullet.GetComponent<DataOfProjectile>();
            cleanPrefab.CleanProjectile(bullet);
            bullet.SetActive(false);
        }
        else if (bullet.layer != collision.gameObject.layer)
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
            {
                CleanPrefab cleanPrefab = new CleanPrefab();
                DataOfProjectile dataOfProjectile = bullet.GetComponent<DataOfProjectile>();
                float damage = dataOfProjectile.Damage * dataOfProjectile.DamageIndex;
                HealtheAndShieldController healtheAndShieldController = new HealtheAndShieldController();
                healtheAndShieldController.TakeDamage(collision.gameObject, damage, false);
                cleanPrefab.CleanProjectile(bullet);
                bullet.SetActive(false);
            }
            else if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
            {
                CleanPrefab cleanPrefab = new CleanPrefab();
                DataOfProjectile dataOfProjectile = bullet.GetComponent<DataOfProjectile>();
                float damage = dataOfProjectile.Damage * dataOfProjectile.DamageIndex;
                HealtheAndShieldController healtheAndShieldController = new HealtheAndShieldController();
                healtheAndShieldController.TakeDamage(collision.gameObject, damage, true);
                cleanPrefab.CleanProjectile(bullet);
                bullet.SetActive(false);
            }
        }
    }
    public void CheckingObjectLayer(GameObject thisGun, GameObject touchedObject)
    {

        if (touchedObject.layer == LayerMask.NameToLayer("Meteorite"))
        {
            Debug.Log("Meteorite");
        }
        else if (thisGun.layer != touchedObject.layer)
        {
            if (touchedObject.layer == LayerMask.NameToLayer("Enemy"))
            {
                Debug.Log("eNEMY");
                DataOfGun dataOfGun = thisGun.GetComponent<DataOfGun>();
                float damage = dataOfGun.Damage * dataOfGun.DamageIndex;
                HealtheAndShieldController healtheAndShieldController = new HealtheAndShieldController();
                healtheAndShieldController.TakeDamage(touchedObject, damage, false);
            }
            else if (touchedObject.layer == LayerMask.NameToLayer("Player"))
            {
                DataOfGun dataOfGun = thisGun.GetComponent<DataOfGun>();
                float damage = dataOfGun.Damage * dataOfGun.DamageIndex;
                HealtheAndShieldController healtheAndShieldController = new HealtheAndShieldController();
                healtheAndShieldController.TakeDamage(touchedObject, damage, true);
            }
        }
    }
}
