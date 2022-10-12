using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : MonoBehaviour
{
    public static LevelData instance;
    [SerializeField] private int _waveOfEnemies;
    [SerializeField] private Transform _meteoriteConteiner;
    [SerializeField] private Transform _projectileConteiner;
    [SerializeField] private Transform _enemiesConteiner;
    [SerializeField] private List<Transform> _positionForEnemies;

    private void Awake()
    {
        instance = this;
    }
    public int WaveOfEnemies
    {
        get { return _waveOfEnemies; }
        set { _waveOfEnemies = value; }
    }
    public List<Transform> PositionForEnemies
    {
        get { return _positionForEnemies; }
    }
    public Transform MeteoriteConteiner
    {
        get { return _meteoriteConteiner; }
    }
    public Transform ProjectileConteiner
    {
        get { return _projectileConteiner; }
    }
    public Transform EnemiesConteiner
    {
        get { return _enemiesConteiner; }
    }
}
