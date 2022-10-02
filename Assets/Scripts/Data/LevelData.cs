using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : MonoBehaviour
{
    public static LevelData instance;
    [SerializeField] private int _waveOfEnemies;
    [SerializeField] private Transform _meteoriteConteiner;
    [SerializeField] private Transform _projectileConteiner;
    private void Awake()
    {
        instance = this;
    }
    public int WaveOfEnemies
    {
        get { return _waveOfEnemies; }
        set { _waveOfEnemies = value; }
    }
    public Transform MeteoriteConteiner
    {
        get { return _meteoriteConteiner; }
    }
    public Transform ProjectileConteiner
    {
        get { return _projectileConteiner; }
    }
}
