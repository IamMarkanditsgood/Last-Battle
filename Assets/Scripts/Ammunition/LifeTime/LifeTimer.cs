using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimer
{
    public IEnumerator WaitDeath(float timeLife, GameObject bullet)
    {
        yield return new WaitForSeconds(timeLife);
        CleanPrefab cleanPrefab = new CleanPrefab();
        cleanPrefab.DeleteParticle(bullet.GetComponent<DataOfProjectile>());
        bullet.SetActive(false);
    }
}
