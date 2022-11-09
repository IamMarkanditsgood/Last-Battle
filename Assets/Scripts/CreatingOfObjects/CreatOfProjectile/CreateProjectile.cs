using UnityEngine;

namespace CreatingAnObjects
{
    public class CreateProjectile
    {
        private DataOfProjectile _dataOfProjectile;
        public void CreateNewFeatures(float damageIndex, GameObject bullet)
        {
            _dataOfProjectile = bullet.GetComponent<DataOfProjectile>();
            _dataOfProjectile.DamageIndex = damageIndex;

            if (_dataOfProjectile.ScriptableObjects.Mesh != null)
            {
                AddMesh(bullet);
            }
            if (_dataOfProjectile.ScriptableObjects.Material != null)
            {
                AddMaterial(bullet);
            }

            if (_dataOfProjectile.ScriptableObjects.Particles != null)
            {
                AddParticle(bullet);
            }
            bullet.transform.localScale = _dataOfProjectile.ScriptableObjects.Size;
            //gameObject.tag = _dataOfProjectile.ScriptableObjects.Name;
        }
        private void AddMesh(GameObject bullet)
        {
            MeshFilter mesh = bullet.GetComponent<MeshFilter>();
            mesh.mesh = _dataOfProjectile.ScriptableObjects.Mesh;
        }
        private void AddMaterial(GameObject bullet)
        {
            MeshRenderer meshRenderer = bullet.GetComponent<MeshRenderer>();
            meshRenderer.sharedMaterial = _dataOfProjectile.ScriptableObjects.Material;
        }
        private void AddParticle(GameObject bullet)
        {
            GameObject particles = Object.Instantiate(_dataOfProjectile.ScriptableObjects.Particles, bullet.transform.position, bullet.transform.rotation);
            particles.transform.SetParent(bullet.transform);
            _dataOfProjectile.CurrentParticles = particles;
        }
    }
}
