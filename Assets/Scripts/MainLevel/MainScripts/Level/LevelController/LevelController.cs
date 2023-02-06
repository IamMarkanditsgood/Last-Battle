using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShipData;
using UnityEditor.Rendering;

public class LevelController : MonoBehaviour
{
    [SerializeField] private LevelData _levelData;
    private Coroutine _coroutine;
    private int _numberOfKilledEnemies = 0;
    private WaveController _waveController;
    private FollowForPlayer _followForPlayer;
    private ShopAreaController shopAreaController;
   
    private void Start()
    {
        _followForPlayer = new FollowForPlayer();
        shopAreaController = new ShopAreaController();
        
        _waveController = new WaveController();
        _waveController.SpawnFirstWave(_levelData);
        if (_levelData == null)
        {
            _levelData = LevelData.instance;
        }
        Time.timeScale = 0;
        _levelData.Player.SetActive(true);
        CreatingController creatingController = new CreatingController();
        creatingController.CreateScene();

    }
    private void Update()
    {
        if (_levelData.LoseLevel)
        {
            Time.timeScale = 0;
        }

        _waveController.CheckTheWave(this, _levelData);
        shopAreaController.CanUseShop(_levelData.MainUIDatas, _levelData.ShopArea);
    }

    private void FixedUpdate()
    {

        _followForPlayer.MoveToObject(_levelData.MainCamera,_levelData.Player.transform,_levelData.YPosForMainCamera,_levelData.SpeedOfCameraFollowing);
    }
    private void OnEnable()
    {
        _coroutine = StartCoroutine(TimeBetweenWaves(_levelData.TimeOfPeace));
    }
    private void OnDisable()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }
    }
    private void OnDestroy()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }
    }
    public IEnumerator TimeBetweenWaves(float timeOfPeace)
    {
        yield return new WaitForSeconds(timeOfPeace);
        NewWave newWave= new NewWave();
        newWave.StartNewWave(_waveController,_levelData);
        StopCoroutine(_coroutine);
    }
    public int NumberOfKilledEnemies
    {
        get { return _numberOfKilledEnemies; }
        set { _numberOfKilledEnemies = value; }
    }
}
