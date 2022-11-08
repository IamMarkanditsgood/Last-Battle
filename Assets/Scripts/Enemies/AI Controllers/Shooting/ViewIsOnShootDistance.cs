using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewIsOnShootDistance : MonoBehaviour
{
    [SerializeField] private GameObject _objectWithGunsList;
    [SerializeField] private LayerMask _layerOfEnemy;
    private IGanListOfShip DataWithGuns;
    private List<GameObject> listOfGuns;
    private float _finishTime;
    private float _time;
    private void Start()
    {
        DataWithGuns = _objectWithGunsList.GetComponent<IGanListOfShip>();
        listOfGuns = DataWithGuns.TakeListOfGuns();
        _finishTime = gameObject.GetComponent<DataOfEnemies>().RechargeTime;
    }
    private void OnEnable()
    {
        _finishTime = gameObject.GetComponent<DataOfEnemies>().RechargeTime;
    }
    void FixedUpdate()
    { 
        RaycastHit hit;
        bool canShoot = Recharge();
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 50, _layerOfEnemy.value) && canShoot)
        {
            for(int i = 0; i < listOfGuns.Count; i++ )
            {
                if(listOfGuns[i].activeInHierarchy)
                {
                    IStandardShot shootFromGun = listOfGuns[i].GetComponent<IStandardShot>();
                    shootFromGun.Shoot();
                }
            }
        }
    }
    private bool Recharge()
    {
        if (_time >= _finishTime)
        {
            _time = 0;
            return true;
        }
        else
        {
            _time += Time.deltaTime;
            return false;
        }
    }
}
