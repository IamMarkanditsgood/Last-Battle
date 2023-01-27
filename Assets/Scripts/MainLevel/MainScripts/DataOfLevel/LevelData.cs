using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : MonoBehaviour
{
    public static LevelData instance;
    [SerializeField] private MainDatas _mainDatas;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _shopArea;
    [SerializeField] private int _waveOfEnemies;
    [SerializeField] private int _money;
    [SerializeField] private float _timeForPeace;
    [SerializeField] private Transform _meteoriteConteiner;
    [SerializeField] private Transform _projectileConteiner;
    [SerializeField] private Transform _enemiesConteiner;
    [SerializeField] private Transform _effectsConteiner;
    [SerializeField] private Transform _soundsConteiner;
    [SerializeField] private List<Transform> _positionForEnemies;
    [SerializeField] private List<GameObject> _listOfEnemiesOnScene;
    [SerializeField] private bool _canDie;
    [SerializeField] private bool _canSpawnOfEnemies;
    [SerializeField] private bool _isPeacefulTime = false;
    [SerializeField] private bool _loseLevel = false;
    private void Awake()
    {
        instance = this;
    }
    public MainDatas MainDatas
    {
        get { return _mainDatas; }
    }
    public bool CanDie
        { get { return _canDie; } }
    public bool CanSpawnOfEnemies
        { get { return _canSpawnOfEnemies; } }
    public bool LoseLevel
    {
        get { return _loseLevel; }
        set { _loseLevel = value; }
    }
    public GameObject Player
    {
        get { return _player; }
    }
    public GameObject ShopArea
    {
        get { return _shopArea; }
    }
    public bool IsPeacefulTime
        { get { return _isPeacefulTime; } set { _isPeacefulTime = value; } }
    public int WaveOfEnemies
    {
        get { return _waveOfEnemies; }
        set { _waveOfEnemies = value; }
    }
    public int Money { get { return _money; } set { _money = value; } }
    public float TimeOfPeace
    {
        get { return _timeForPeace; }
    }
    public List<Transform> PositionForEnemies
    {
        get { return _positionForEnemies; }
    }
    public List<GameObject> ListOfEnemiesOnScene
    {
        get { return _listOfEnemiesOnScene; }
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
    public Transform EffectsConteiner
    {
        get { return _effectsConteiner; }
    }
    public Transform SoundsConteiner
    {
        get { return _soundsConteiner; }
    }
}
