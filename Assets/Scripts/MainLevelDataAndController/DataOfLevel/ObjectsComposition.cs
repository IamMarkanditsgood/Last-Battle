using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class ObjectsComposition : MonoBehaviour
{
    public static ObjectsComposition instance;

    [SerializeField] private List<GameObject> _poolStandardBullets;
    [SerializeField] private List<GameObject> _poolAlianEnemies;
    [SerializeField] private List<GameObject> _poolImperialEnemies;
    [SerializeField] private List<GameObject> _poolEffects;
    [SerializeField] private List<GameObject> _poolSounds;

    private void Awake()
    {
        instance = this;
    }

    public GameObject PoolStandardBullets
    {
        get
        {
            for (int i = 0; i < _poolStandardBullets.Count; i++)
            {
                if (!_poolStandardBullets[i].activeInHierarchy)
                {

                    return _poolStandardBullets[i];
                }
            }
            SpawnOfProjectiles spawnOfProjectiles = new SpawnOfProjectiles();
            spawnOfProjectiles.CreateNewProjectile(PrefabsStorey.instance.Projectile);
            int _lastObjectInList = _poolStandardBullets.Count - 1;
            return _poolStandardBullets[_lastObjectInList];
        }
        set { _poolStandardBullets.Add(value); }
    }

    public List<GameObject> PoolAlianEnemies
    {
        get { return _poolAlianEnemies; }
        set { _poolAlianEnemies = value; }
    }
    public List<GameObject> PoolImperialEnemies
    {
        get { return _poolImperialEnemies; }
        set { _poolImperialEnemies = value; }
    }
    public List<GameObject> PoolEffects
    {
        get { return _poolEffects; }
        set { _poolEffects = value; }
    }
    public List<GameObject> PoolSounds
    {
        get { return _poolSounds; }
        set { _poolSounds = value; }
    }

    public GameObject GetEnemyShip(ERacesOfShips eRacesOfShips, EEnemiesType eEnemiesType)
    {
        List<GameObject> list = FindListOfShipRace(eRacesOfShips);

        for (int i = 0; i < list.Count; i++)
        {
            EEnemiesType type = list[i].GetComponent<DataOfEnemies>().ScriptableObjectOfEnemy.TypeOfShip;
            if (!list[i].activeInHierarchy && type == eEnemiesType)
            {
                return list[i];
            }
        }

        SpawnOfEnemys spawnOfEnemy = new SpawnOfEnemys();

        GameObject enemyPrefab = PrefabsStorey.instance.GetEnemyShipByTypeAndRaceFromPrefabe(eRacesOfShips, eEnemiesType);

        GameObject spawnedEnemy = spawnOfEnemy.SpawnOfEnemy(enemyPrefab);
        spawnOfEnemy.AddEnemyShipToList(spawnedEnemy);
        return list[list.Count - 1];
    }
    public GameObject GetEffect(ETypeOfEffect TypeOfEffect)
    {
        for (int i = 0; i < _poolEffects.Count; i++)
        {
            if (!_poolEffects[i].activeInHierarchy && _poolEffects[i].GetComponent<EffectObjData>().TypeOfEffect == TypeOfEffect)
            {
                return _poolEffects[i];
            }
        }

        SpawnOfEffects spawnOfEffects = new SpawnOfEffects();

        spawnOfEffects.CreateEffect(TypeOfEffect);
        return _poolEffects[_poolEffects.Count - 1];
    }
    public GameObject GetSound(ETypeOfSound TypeOfSound)
    {
        for (int i = 0; i < _poolSounds.Count; i++)
        {
            if (!_poolSounds[i].activeInHierarchy && _poolSounds[i].GetComponent<DataOfSound>().TypeOfSound == TypeOfSound)
            {

                return _poolSounds[i];
            }
        }

        SpawnOfSounds spawnOfSounds = new SpawnOfSounds();

        spawnOfSounds.CreateSound(TypeOfSound);

        return _poolSounds[_poolSounds.Count - 1];
    }

    public List<GameObject> FindListOfShipRace(ERacesOfShips eRacesOfShips)
    {
        switch (eRacesOfShips)
        {
            case 0:
                return _poolImperialEnemies;
            case (ERacesOfShips)1:
                return _poolAlianEnemies;
            default:
                print("Error: You forgot to add to List for this race or forgot to add case in switch in method FindListOfShipRace!!");
                return null;
        }
    }
    public List<GameObject> FindListOfShipRace(GameObject obj)
    {
        ERacesOfShips enemyRace = obj.GetComponent<DataOfEnemies>().ScriptableObjectOfEnemy.RaceOfShip;
        switch (enemyRace)
        {
            case 0:
                return _poolImperialEnemies;
            case (ERacesOfShips)1:
                return _poolAlianEnemies;
            default:
                print("Error: You forgot to add to List for this race or forgot to add case in switch in method FindListOfShipRace!!");
                return null;
        }
    }
}
