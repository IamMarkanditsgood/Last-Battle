using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateProjectile : MonoBehaviour
{
    private DataOfProjectile _dataOfProjectile;
    public void CreateNewFeatures()
    {
        _dataOfProjectile = gameObject.GetComponent<DataOfProjectile>();
        MeshFilter mesh = GetComponent <MeshFilter>();
        mesh.mesh = _dataOfProjectile.ScriptableObjects.Mesh;
        MeshRenderer meshRenderer = GetComponent <MeshRenderer>();  
        meshRenderer.sharedMaterial = _dataOfProjectile.ScriptableObjects.Material;
        gameObject.transform.localScale = _dataOfProjectile.ScriptableObjects.Size;
        gameObject.tag = _dataOfProjectile.ScriptableObjects.Name;
    }
}
