using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AmmunitionScriptableObject", menuName = "Ammunition ScriptableObject", order = 51)]
public class AmmunitionData : ScriptableObject
{
    [SerializeField] private ETypeOfProjectile _typeOfProjectile;
    [SerializeField] private Material _material;
    [SerializeField] private Mesh _mesh;
    [SerializeField] private float _speed;
    [SerializeField] private float _lifeTime;
    [SerializeField] private Vector3 _size;
    [SerializeField] private GameObject _particles;

    public ETypeOfProjectile TypeOfProjectile => _typeOfProjectile;
    public GameObject Particles => _particles;
    public Material Material => _material;
    public Mesh Mesh => _mesh;
    public float Speed => _speed;
    public float LifeTime => _lifeTime;
    public Vector3 Size => _size;
}
