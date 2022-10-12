using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFromGun : MonoBehaviour, IStandardShot
{
    DataOfGun dataOfGun;
    private void Awake()
    {
        dataOfGun = GetComponent<DataOfGun>();
    }
    public void Shoot()
    { 
        
        GameObject bullet = GetObject();
        if (bullet != null)
        {
            bullet.transform.position = dataOfGun.PositionForSooting.position;
            bullet.transform.rotation = gameObject.transform.rotation;
            bullet.GetComponent<DataOfProjectile>().ScriptableObjects = dataOfGun.ScriptableObject;
            bullet.SetActive(true);
            bullet.GetComponent<CreateProjectile>().CreateNewFeatures(gameObject.GetComponent<DataOfGun>().DamageIndex);
        }
    }
    private GameObject GetObject()
    {
        ObjectsComposition ammunitionStore = ObjectsComposition.Instance;
        GameObject bullet = ammunitionStore.PoolStandardBullets;
        return bullet;
    }

   
}
