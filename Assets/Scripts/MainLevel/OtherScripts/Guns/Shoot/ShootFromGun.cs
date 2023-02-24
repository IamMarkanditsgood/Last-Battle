using System.Collections;
using UnityEngine;
using CreatingAnObjects;

public class ShootFromGun : MonoBehaviour, IStandardShoot
{
    private ObjectsComposition _objectsComposition = ObjectsComposition.instance;
    private DataOfGun _dataOfGun;

    private Coroutine _coroutine;

    private void Awake()
    {
        _dataOfGun = GetComponent<DataOfGun>(); 
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

    public void Shoot()
    {
        if (_dataOfGun.IsCharged)
        {
            GameObject bullet = GetObject();
            if (bullet != null)
            {
                CreateProjectile createProjectile = new CreateProjectile();

                UseShotEffect();
                UseShotSound();
                SetTransform(bullet);
                SetScriptableObjAndLayer(bullet);
                createProjectile.CustomizeProjectile(_dataOfGun, bullet);

                _dataOfGun.IsCharged = false;

                _coroutine = StartCoroutine(WaitShoot(_dataOfGun.ReCharge));
            }
        }
    }
    private GameObject GetObject()
    {
        ObjectsComposition ammunitionStore = ObjectsComposition.instance;

        GameObject bullet = ammunitionStore.PoolStandardBullets;

        return bullet;
    }
    private void SetScriptableObjAndLayer(GameObject bullet)
    {
        bullet.GetComponent<DataOfProjectile>().ScriptableObjects = _dataOfGun.Bullet;
        bullet.layer = gameObject.layer;
        bullet.SetActive(true);
    }
    private void SetTransform(GameObject bullet)
    {
        bullet.transform.position = _dataOfGun.PositionForSooting.position;
        bullet.transform.rotation = _dataOfGun.PositionForSooting.rotation;
    }
    private void UseShotEffect()
    {
        if (_dataOfGun.TypeOfShotEffect != ETypeOfEffect.None)
        {
            EffectController effectController = new EffectController();
            effectController.UseEffect(_dataOfGun.TypeOfShotEffect, _dataOfGun.PositionForSooting);
        }
    }
    private void UseShotSound()
    {
        if (_dataOfGun.TypeOfSound != ETypeOfSound.None)
        {
            _objectsComposition = ObjectsComposition.instance;

            GameObject soundObj = _objectsComposition.GetSound(_dataOfGun.TypeOfSound);
            soundObj.SetActive(true);
            soundObj.AddComponent<cleaner>();
        }
    }

}
