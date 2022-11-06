using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchingObjects : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            CleanPrefab cleanPrefab = new CleanPrefab();
            DataOfProjectile dataOfProjectile = GetComponent<DataOfProjectile>();
            ControllerOfHealthe controllerOfHealthe =  collision.gameObject.GetComponent<ControllerOfHealthe>();
            float damage = gameObject.GetComponent<DataOfProjectile>().ScriptableObjects.Damage * dataOfProjectile.DamageIndex;
            controllerOfHealthe.TakeDamage(damage);
            cleanPrefab.DeleteParticle(dataOfProjectile);
            gameObject.SetActive(false);
            
        }
    }
}
