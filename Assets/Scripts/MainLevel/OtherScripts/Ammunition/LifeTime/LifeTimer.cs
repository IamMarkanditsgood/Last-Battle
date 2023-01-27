using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimer
{
    public IEnumerator WaitDeath(float timeLife, GameObject bullet)
    {
        yield return new WaitForSeconds(timeLife);
        CleanPrefab cleanPrefab = new CleanPrefab();
        cleanPrefab.CleanProjectile(bullet);
        bullet.SetActive(false);
    }
}
