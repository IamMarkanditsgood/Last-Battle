using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsComposition : MonoBehaviour
{
    public static ObjectsComposition Instance;

    [SerializeField] private List<GameObject> _pooledStandardBullets = new List<GameObject>();
    [SerializeField] private List<GameObject> _pooledEnemies = new List<GameObject>();
    private void Awake()
    {
        Instance = this;
    }
    public GameObject PooledStandardBullets
    {
        get {
            for (int i = 0; i < _pooledStandardBullets.Count; i++)
            {
                if (!_pooledStandardBullets[i].activeInHierarchy)
                {
                    
                    return _pooledStandardBullets[i];
                }
            }
            SpawnOfProjectiles spawnOfProjectiles = new SpawnOfProjectiles();
            spawnOfProjectiles.CreateNewProjectile(PrefabsStorey.instance.Projectile);
            int _lastObjectInList = _pooledStandardBullets.Count - 1;
            return _pooledStandardBullets[_lastObjectInList];
        }
        set { _pooledStandardBullets.Add(value); }
    }

    public GameObject PooledEnemies
    {
        get
        {
            for (int i = 0; i < _pooledEnemies.Count; i++)
            {
                if (!_pooledEnemies[i].activeInHierarchy)
                {

                    return _pooledEnemies[i];
                }
            }
            SpawnOfProjectiles spawnOfProjectiles = new SpawnOfProjectiles();
            spawnOfProjectiles.CreateNewProjectile(PrefabsStorey.instance.Projectile);
            int _lastObjectInList = _pooledEnemies.Count - 1;
            return _pooledEnemies[_lastObjectInList];
        }
        set { _pooledEnemies.Add(value); }
    }
}
