using UnityEngine;

public class CleanPrefab
{
    public void CleanProjectile(GameObject currentBullet)
    {
        DataOfProjectile dataOfProjectile = currentBullet.GetComponent<DataOfProjectile>();

        currentBullet.GetComponent<MeshRenderer>().sharedMaterial = null;
        currentBullet.GetComponent<MeshFilter>().mesh = null;
        dataOfProjectile.CurrentTarget = null;

        Object.Destroy(dataOfProjectile.CurrentParticles);
    }
}
