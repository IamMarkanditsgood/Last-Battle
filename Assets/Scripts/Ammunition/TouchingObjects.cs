using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchingObjects : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            ControllerOfHealthe controllerOfHealthe =  collision.gameObject.GetComponent<ControllerOfHealthe>();
            float damage = gameObject.GetComponent<DataOfProjectile>().ScriptableObjects.Damage * gameObject.GetComponent<DataOfProjectile>().DamageIndex;
            controllerOfHealthe.TakeDamage(damage);
        }
    }
}
