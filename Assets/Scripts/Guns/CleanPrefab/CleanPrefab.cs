using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanPrefab
{
    public void DeleteParticle(DataOfProjectile dataOfProjectile)
    {
        Object.Destroy(dataOfProjectile.CurrentParticles);
    }
}
