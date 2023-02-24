using UnityEngine;

public class SpawnOfProjectiles : AFirstSpawn
{
    private const int _numberOfFirstProjectiles = 25;

    public override void FirstSpawn()
    {
        for (int i = 0; i < _numberOfFirstProjectiles; i++)
        {
            CreateNewProjectile(PrefabsStorey.instance.Projectile);
        }
    }

    public void CreateNewProjectile(GameObject bullet)
    {
        CreatorOfObjectForPool creatorOfObjectForPool = new CreatorOfObjectForPool();
        ObjectsComposition ammunitionStore = ObjectsComposition.instance;

        GameObject obj = creatorOfObjectForPool.CreateObjectAndPrepearIt(bullet, LevelData.instance.ProjectileConteiner);
        ammunitionStore.PoolStandardBullets = obj;
        
    }

}
