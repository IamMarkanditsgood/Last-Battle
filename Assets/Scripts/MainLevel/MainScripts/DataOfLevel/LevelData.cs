using System.Collections.Generic;
using UnityEngine;

public class LevelData : MonoBehaviour
{
    public static LevelData instance;

    [SerializeField] private MainDatas _mainUIDatas;

    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _mainCamera;
    [SerializeField] private GameObject _shopArea;
    [SerializeField] private GameObject _cursor;

    [SerializeField] private Transform _meteoriteConteiner;
    [SerializeField] private Transform _projectileConteiner;
    [SerializeField] private Transform _enemiesConteiner;
    [SerializeField] private Transform _effectsConteiner;
    [SerializeField] private Transform _soundsConteiner;
    [SerializeField] private Transform _buffConteiner;

    [SerializeField] private List<GameObject> _listOfEnemiesOnScene;
    [SerializeField] private List<Transform> _positionForEnemies;

    [SerializeField] private int _waveOfEnemies;
    [SerializeField] private int _money;
    [SerializeField] private int _numberOfMeteorites;
    [SerializeField] private int _basickMoneyForEnemyKill = 100;

    [SerializeField] private float _timeForPeace;
    [SerializeField] private float _yPosForMainCam;
    [SerializeField] private float _speedOfCameraFollowing;
    [SerializeField] private float _xLevelSize;
    [SerializeField] private float _zLevelSize;

    [SerializeField] private bool _canDie;
    [SerializeField] private bool _canSpawnOfEnemies;

    private bool _isPeacefulTime = false;
    private bool _loseLevel = false;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public MainDatas MainUIDatas
    {
        get { return _mainUIDatas; }
    }

    public GameObject Player
    {
        get { return _player; }
    }
    public GameObject ShopArea
    {
        get { return _shopArea; }
    }
    public GameObject MainCamera
    {
        get { return _mainCamera; }
    }
    public GameObject Cursor
    { 
        get { return _cursor; } 
    }

    public List<GameObject> ListOfEnemiesOnScene
    {
        get { return _listOfEnemiesOnScene; }
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
    public Transform EffectsConteiner
    {
        get { return _effectsConteiner; }
    }
    public Transform SoundsConteiner
    {
        get { return _soundsConteiner; }
    }
    public Transform BuffConteiner
    {
        get { return _buffConteiner; }
    }

    public int WaveOfEnemies
    {
        get { return _waveOfEnemies; }
        set { _waveOfEnemies = value; }
    }
    public int Money
    {
        get { return _money; }
        set { _money = value; }
    }
    public int NumberOfMeteorites
    {
        get { return _numberOfMeteorites; }
        set { _numberOfMeteorites = value; }
    }
    public int BasickMoneyForEnemyKill
    {
        get { return _basickMoneyForEnemyKill; }
    }

    public float TimeOfPeace
    {
        get { return _timeForPeace; }
        set { _timeForPeace = value; }
    }
    public float XLevelSize
    {
        get { return _xLevelSize; }
        set { _xLevelSize = value; }
    }
    public float ZLevelSize
    {
        get { return _zLevelSize; }
        set { _zLevelSize = value; }
    }
    public float YPosForMainCamera
    {
        get { return _yPosForMainCam; }
    }
    public float SpeedOfCameraFollowing
    {
        get { return _speedOfCameraFollowing; }
    }

    public bool CanDie
    { 
        get { return _canDie; } 
    }
    public bool CanSpawnOfEnemies
    { 
        get { return _canSpawnOfEnemies; } 
    }
    public bool LoseLevel
    {
        get { return _loseLevel; }
        set { _loseLevel = value; }
    }
    public bool IsPeacefulTime
    { 
        get { return _isPeacefulTime; } 
        set { _isPeacefulTime = value; } 
    }
    
    
}
