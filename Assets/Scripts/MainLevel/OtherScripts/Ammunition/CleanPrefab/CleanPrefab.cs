using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanPrefab
{
    public void CleanProjectile(GameObject curentBullet)
    {
        DataOfProjectile dataOfProjectile = curentBullet.GetComponent<DataOfProjectile>();
        curentBullet.GetComponent<MeshRenderer>().sharedMaterial = null;
        curentBullet.GetComponent<MeshFilter>().mesh = null;
        Object.Destroy(dataOfProjectile.CurrentParticles);
    }
}
