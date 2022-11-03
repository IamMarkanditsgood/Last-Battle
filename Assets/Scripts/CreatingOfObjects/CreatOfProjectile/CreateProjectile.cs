using UnityEngine;

public class CreateProjectile : MonoBehaviour
{
    private DataOfProjectile _dataOfProjectile;
    public void CreateNewFeatures(float damageIndex)
    {
        _dataOfProjectile = gameObject.GetComponent<DataOfProjectile>();
        _dataOfProjectile.DamageIndex = damageIndex;

        MeshFilter mesh = GetComponent <MeshFilter>();
        mesh.mesh = _dataOfProjectile.ScriptableObjects.Mesh;

        MeshRenderer meshRenderer = GetComponent <MeshRenderer>();  
        meshRenderer.sharedMaterial = _dataOfProjectile.ScriptableObjects.Material;

        gameObject.transform.localScale = _dataOfProjectile.ScriptableObjects.Size;
        gameObject.tag = _dataOfProjectile.ScriptableObjects.Name;

        GameObject particles =  Instantiate(_dataOfProjectile.ScriptableObjects.Particles, transform.position, transform.rotation );
        particles.transform.SetParent(gameObject.transform);
    }
}
