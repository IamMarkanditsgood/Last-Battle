using UnityEngine;

namespace CreatingAnObjects
{
    public class CreateProjectile
    {
        public void CustomizeProjectile(DataOfGun dataOfGun, GameObject bullet)
        {
            DataOfProjectile dataOfProjectile = bullet.GetComponent<DataOfProjectile>();
            dataOfProjectile = bullet.GetComponent<DataOfProjectile>();

            SetDataOfProjectile(dataOfGun, bullet, dataOfProjectile);
            SetSizesOfProjectile(bullet, dataOfProjectile);
            AddMesh(bullet, dataOfProjectile);
            AddMaterial(bullet, dataOfProjectile);
            AddParticle(bullet, dataOfProjectile);
        }
        private void SetDataOfProjectile(DataOfGun dataOfGun, GameObject bullet, DataOfProjectile dataOfProjectile)
        {
            dataOfProjectile.DamageIndex = dataOfGun.DamageIndex;
            dataOfProjectile.Damage = dataOfGun.Damage;
            dataOfProjectile.OwnersShip = dataOfGun.GunOwner;
        }
        private void SetSizesOfProjectile(GameObject bullet, DataOfProjectile dataOfProjectile)
        {
            bullet.transform.localScale = dataOfProjectile.ScriptableObjects.Size;
            bullet.GetComponent<SphereCollider>().radius = dataOfProjectile.ScriptableObjects.SizeOfCollider;
        }
        private void AddMesh(GameObject bullet, DataOfProjectile dataOfProjectile)
        {
            if (dataOfProjectile.ScriptableObjects.Mesh != null)
            {
                MeshFilter mesh = bullet.GetComponent<MeshFilter>();
                mesh.mesh = dataOfProjectile.ScriptableObjects.Mesh;
            }
        }
        private void AddMaterial(GameObject bullet, DataOfProjectile dataOfProjectile)
        {
            if (dataOfProjectile.ScriptableObjects.Material != null)
            {
                MeshRenderer meshRenderer = bullet.GetComponent<MeshRenderer>();
                meshRenderer.sharedMaterial = dataOfProjectile.ScriptableObjects.Material;
            }
        }
        private void AddParticle(GameObject bullet, DataOfProjectile dataOfProjectile)
        {
            if (dataOfProjectile.ScriptableObjects.Particles != null)
            {
                GameObject particles = Object.Instantiate(dataOfProjectile.ScriptableObjects.Particles, bullet.transform.position, bullet.transform.rotation);
                particles.transform.SetParent(bullet.transform);
                dataOfProjectile.CurrentParticles = particles;
            }
        }
    }
}
