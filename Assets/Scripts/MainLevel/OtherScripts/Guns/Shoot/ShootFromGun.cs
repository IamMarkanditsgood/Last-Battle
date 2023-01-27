using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatingAnObjects;

public class ShootFromGun : MonoBehaviour, IStandardShoot
{
    private DataOfGun _dataOfGun;
    private Coroutine _coroutine;
    private ObjectsComposition _objectsComposition = ObjectsComposition.Instance;
    private RunEffect _runEffect = new RunEffect();
    private void Awake()
    {
        _dataOfGun = GetComponent<DataOfGun>(); 
    }
    public void Shoot()
    {
        if (_dataOfGun.IsCharged)
        {
            GameObject bullet = GetObject();
            if (bullet != null)
            {
                if(_dataOfGun.GetParticleObject(ETypeOfEffect.Shoot))
                {
                    _runEffect.PlayEffect(_dataOfGun.GetParticleObject(ETypeOfEffect.Shoot));
                }
                _objectsComposition = ObjectsComposition.Instance;

                GameObject soundObj = _objectsComposition.GetSound(_dataOfGun.TypeOfSound);
                soundObj.SetActive(true);
                soundObj.AddComponent<cleaner>();
                bullet.transform.position = _dataOfGun.PositionForSooting.position;
                bullet.transform.rotation = _dataOfGun.PositionForSooting.rotation;
                bullet.SetActive(true);
                bullet.GetComponent<DataOfProjectile>().ScriptableObjects = _dataOfGun.Bullet;
                bullet.layer = gameObject.layer;
                CreateProjectile createProjectile = new CreateProjectile();
                createProjectile.CreateNewFeatures(_dataOfGun, bullet);
                _dataOfGun.IsCharged = false;
                _coroutine = StartCoroutine(WaitShoot(_dataOfGun.ReCharge));
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
    public IEnumerator WaitShoot(float rechargeTime)
    {
        
        yield return new WaitForSeconds(rechargeTime);
        _dataOfGun.IsCharged = true;
        StopCoroutine(_coroutine);
    }


}
