using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectObjData : MonoBehaviour
{
    [SerializeField] private ETypeOfEffect _typeOfEffect;
    [SerializeField] private List<ParticleSystem> _particleSystems;

    public ETypeOfEffect TypeOfEffect
    {
        get { return _typeOfEffect; }
    }
    public List<ParticleSystem> ParticleSystemsList
    { get { return _particleSystems; } }
}
