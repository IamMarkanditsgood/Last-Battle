using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatingAnObjects;

public class ShootFromGun : MonoBehaviour, IStandardShoot
{
    private DataOfGun dataOfGun;
    private Coroutine _coroutine;
    private void Awake()
    {
        dataOfGun = GetComponent<DataOfGun>();
    }
    public void Shoot()
    {
        if (dataOfGun.IsCharged)
        {
            GameObject bullet = GetObject();
            if (bullet != null)
            {
                bullet.transform.position = dataOfGun.PositionForSooting.position;
                bullet.transform.rotation = dataOfGun.PositionForSooting.rotation;
                bullet.GetComponent<DataOfProjectile>().ScriptableObjects = dataOfGun.Bullet;
                bullet.SetActive(true);
                CreateProjectile createProjectile = new CreateProjectile();
                createProjectile.CreateNewFeatures(dataOfGun, bullet);
                dataOfGun.IsCharged = false;
                _coroutine = StartCoroutine(WaitDeath(dataOfGun.ReCharge));
            }
        }
    }
    private GameObject GetObject()
    {
        ObjectsComposition ammunitionStore = ObjectsComposition.Instance;
        GameObject bullet = ammunitionStore.PoolStandardBullets;
        return bullet;
    }
    private void OnDisable()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

    }
    private void OnDestroy()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }
    }
    public IEnumerator WaitDeath(float rechargeTime)
    {
        
        yield return new WaitForSeconds(rechargeTime);
        dataOfGun.IsCharged = true;
        StopCoroutine(_coroutine);
    }


}
