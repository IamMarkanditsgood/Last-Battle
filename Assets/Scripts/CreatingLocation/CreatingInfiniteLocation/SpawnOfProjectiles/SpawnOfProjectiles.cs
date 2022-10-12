
using System.Collections.Generic;
using UnityEngine;

public class SpawnOfProjectiles : AFirstSpawn
{

    [SerializeField] private GameObject _prefab;
    public override void FirstSpawn()
    {
        StartSetings startSetings = StartSetings.instance;
        for (int i = 0; i < startSetings.NumberOfProjectile; i++)
        {
            CreateNewProjectile(PrefabsStorey.instance.Projectile);
        }
    }
    public void CreateNewProjectile(GameObject bullet)
    {
        ObjectsComposition ammunitionStore = ObjectsComposition.Instance;
        GameObject sphere = Instantiate(bullet);
        sphere.SetActive(false);
        sphere.transform.SetParent(LevelData.instance.ProjectileConteiner);
        ammunitionStore.PoolStandardBullets = sphere;
    }

}
