using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    private IProjectileMover _projectileMover;
    private TouchingObjects _touchingObjects = new TouchingObjects();
    private LifeTimer _lifeTimer = new LifeTimer();
    private DataOfProjectile _dataOfProjectile;
    private Coroutine _coroutine;
    private void Start()
    {
        _projectileMover = GetMoverScript();
        _dataOfProjectile = GetComponent<DataOfProjectile>();

    }
    private void FixedUpdate()
    {
        _projectileMover.MoveProjectile(gameObject);
    }
    private void OnTriggerEnter(Collider collision)
    {
        _touchingObjects.CheckingObjectLayer(collision, gameObject);
    }
    private void OnEnable()
    {
        _projectileMover = GetMoverScript();
        if (GetComponent<DataOfProjectile>().ScriptableObjects != null)
        {

            float _timeLife = GetComponent<DataOfProjectile>().ScriptableObjects.LifeTime;
            _coroutine = StartCoroutine(_lifeTimer.WaitDeath(_timeLife, gameObject));
        }
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
    private IProjectileMover GetMoverScript()
    {
        ETypeOfProjectile eTypeOfProjectile = _dataOfProjectile.ScriptableObjects.TypeOfProjectile;
        switch (eTypeOfProjectile)
        {
            case 0:
                return new AimRocket();
            case (ETypeOfProjectile)1:
                return new MoveOfBullet();
            default:
                return new MoveOfBullet();
        }

    }
}
