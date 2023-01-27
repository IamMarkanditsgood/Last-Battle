using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AmmunitionScriptableObject", menuName = "Ammunition ScriptableObject", order = 51)]
public class AmmunitionData : ScriptableObject
{
    [SerializeField] private ETypeOfProjectile _typeOfProjectile;
    [SerializeField] private ETypeOfEffect _typeOfEffect;
    [SerializeField] private ETypeOfSound _typeOfSound;
    [SerializeField] private Material _material;
    [SerializeField] private Mesh _mesh;
    [SerializeField] private float _speed;
    [SerializeField] private float _lifeTime;
    [SerializeField] private float _sizeOfCollider;
    [SerializeField] private Vector3 _size;
    [SerializeField] private GameObject _particles;

    public ETypeOfProjectile TypeOfProjectile => _typeOfProjectile;
    public ETypeOfEffect TypeOfEffect => _typeOfEffect;
    public ETypeOfSound TypeOfSound => _typeOfSound;
    public GameObject Particles => _particles;
    public Material Material => _material;
    public Mesh Mesh => _mesh;
    public float Speed => _speed;
    public float LifeTime => _lifeTime;
    public float SizeOfCollider => _sizeOfCollider;
    public Vector3 Size => _size;
}
