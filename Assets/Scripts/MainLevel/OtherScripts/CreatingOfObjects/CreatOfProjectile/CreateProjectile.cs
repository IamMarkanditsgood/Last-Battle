using UnityEngine;

namespace CreatingAnObjects
{
    public class CreateProjectile
    {
        
        public void CreateNewFeatures(DataOfGun dataOfGun, GameObject bullet)
        {
            DataOfProjectile _dataOfProjectile = bullet.GetComponent<DataOfProjectile>();
            _dataOfProjectile = bullet.GetComponent<DataOfProjectile>();
            _dataOfProjectile.DamageIndex = dataOfGun.DamageIndex;
            _dataOfProjectile.Damage = dataOfGun.Damage;
            _dataOfProjectile.OwnersShip = dataOfGun.GunOwner;

            if (_dataOfProjectile.ScriptableObjects.Mesh != null)
            {
                AddMesh(bullet, _dataOfProjectile);
            }
            if (_dataOfProjectile.ScriptableObjects.Material != null)
            {
                AddMaterial(bullet, _dataOfProjectile);
            }

            if (_dataOfProjectile.ScriptableObjects.Particles != null)
            {
                
                AddParticle(bullet, _dataOfProjectile);
            }
            bullet.transform.localScale = _dataOfProjectile.ScriptableObjects.Size;
            bullet.GetComponent<SphereCollider>().radius = _dataOfProjectile.ScriptableObjects.SizeOfCollider;
            //gameObject.tag = _dataOfProjectile.ScriptableObjects.Name;
        }
        private void AddMesh(GameObject bullet, DataOfProjectile dataOfProjectile)
        {
            MeshFilter mesh = bullet.GetComponent<MeshFilter>();
            mesh.mesh = dataOfProjectile.ScriptableObjects.Mesh;
        }
        private void AddMaterial(GameObject bullet, DataOfProjectile dataOfProjectile)
        {
            MeshRenderer meshRenderer = bullet.GetComponent<MeshRenderer>();
            meshRenderer.sharedMaterial = dataOfProjectile.ScriptableObjects.Material;
        }
        private void AddParticle(GameObject bullet, DataOfProjectile dataOfProjectile)
        {
            GameObject particles = Object.Instantiate(dataOfProjectile.ScriptableObjects.Particles, bullet.transform.position, bullet.transform.rotation);
            particles.transform.SetParent(bullet.transform);
            dataOfProjectile.CurrentParticles = particles;
        }
    }
}
