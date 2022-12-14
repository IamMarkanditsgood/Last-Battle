using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObjectsComposition : MonoBehaviour
{
    public static ObjectsComposition Instance;

    [SerializeField] private List<GameObject> _poolStandardBullets;
    [SerializeField] private List<GameObject> _poolAlianEnemies;
    [SerializeField] private List<GameObject> _poolImperialEnemies;
    private void Awake()
    {
        Instance = this;
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
    public GameObject GetEnemyShip(ERacesOfShips eRacesOfShips, EEnemiesType eEnemiesType)
    {
        List<GameObject> list = FindListOfShipRace(eRacesOfShips);
        
        for(int i = 0;i < list.Count;i++)
        {
            EEnemiesType type = list[i].GetComponent<DataOfEnemies>().ScriptableObjectOfEnemy.TypeOfShip;
            if (!list[i].activeInHierarchy && type == eEnemiesType)
            {
                return list[i];
            }
        }
        SpawnOfEnemys spawnOfEnemy = new SpawnOfEnemys();
        GameObject enemyPrefab = PrefabsStorey.instance.GetEnemyShipByTypeAndRaceFromPrefabe(eRacesOfShips,eEnemiesType);
        /////
        GameObject spawnedEnemy = spawnOfEnemy.SpawnOfEnemy(enemyPrefab);
        
        spawnOfEnemy.AddEnemyShipToList(spawnedEnemy);
        return list[list.Count-1];

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
    public GameObject PoolStandardBullets
    {
        get {
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
}
