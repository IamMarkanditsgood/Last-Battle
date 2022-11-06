using UnityEngine;

public class CreateProjectile : MonoBehaviour
{
    private DataOfProjectile _dataOfProjectile;
    public void CreateNewFeatures(float damageIndex)
    {
        _dataOfProjectile = gameObject.GetComponent<DataOfProjectile>();
        _dataOfProjectile.DamageIndex = damageIndex;

        if (_dataOfProjectile.ScriptableObjects.Mesh != null)
        {
            AddMesh();
        }
        if (_dataOfProjectile.ScriptableObjects.Material != null)
        {
            AddMaterial();
        }
        
        if (_dataOfProjectile.ScriptableObjects.Particles != null)
        {
            AddParticle();
        }
        gameObject.transform.localScale = _dataOfProjectile.ScriptableObjects.Size;
        //gameObject.tag = _dataOfProjectile.ScriptableObjects.Name;
    }
    private void AddMesh()
    {
        MeshFilter mesh = GetComponent<MeshFilter>();
        mesh.mesh = _dataOfProjectile.ScriptableObjects.Mesh;
    }
    private void AddMaterial()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.sharedMaterial = _dataOfProjectile.ScriptableObjects.Material;
    }
    private void AddParticle()
    {
        GameObject particles = Instantiate(_dataOfProjectile.ScriptableObjects.Particles, transform.position, transform.rotation);
        particles.transform.SetParent(gameObject.transform);
        _dataOfProjectile.CurrentParticles = particles;
    }
}
