using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFromGun : MonoBehaviour
{
    [SerializeField] private Transform _positionsForShooting;
    [SerializeField] private AmmunitionData _scriptableObject;
    public void Shoot()
    { 
        GameObject bullet = GetObject();
        if (bullet != null)
        {
            bullet.transform.position = _positionsForShooting.position;
            bullet.transform.rotation = gameObject.transform.rotation;
            bullet.GetComponent<DataOfProjectile>().ScriptableObjects = _scriptableObject;
            bullet.SetActive(true);
            bullet.GetComponent<CreateProjectile>().CreateNewFeatures();
        }
    }
    private GameObject GetObject()
    {
        ObjectsComposition ammunitionStore = ObjectsComposition.Instance;
        GameObject bullet = ammunitionStore.PooledStandardBullets;
        return bullet;
    }

   
}
