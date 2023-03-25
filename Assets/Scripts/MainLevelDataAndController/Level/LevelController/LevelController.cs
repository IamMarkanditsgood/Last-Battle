using ShipData;
using System.Collections;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] private LevelData _levelData;

    private WaveController _waveController = new WaveController();
    private FollowForPlayer _followForPlayer = new FollowForPlayer();
    private ShopAreaController _shopAreaController = new ShopAreaController();
    private CreatingController _creatingController = new CreatingController();

    private Coroutine _coroutine;
 
    private void Start()
    { 
        if (_levelData == null)
        {
            _levelData = LevelData.instance;
        }

        SetTheScene();
    }

    private void Update()
    {
        if (!IsLevelLosed())
        {
            _waveController.CheckTheWave(this, _levelData,ref _coroutine);
            _shopAreaController.IsCanUseShop(_levelData.MainUIDatas, _levelData.ShopArea);
        }
    }

    private void FixedUpdate()
    {
        _followForPlayer.MoveToObject(_levelData.MainCamera,_levelData.Player.transform,_levelData.YPosForMainCamera,_levelData.SpeedOfCameraFollowing);
        //_followForPlayer.MoveToObject(_levelData.MiniMapCamera, _levelData.Player.transform, _levelData.YPosForMiniMapCam, _levelData.SpeedOfCameraFollowing);
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

        NewWave newWave = new NewWave();

        newWave.StartNewWave(_waveController, _levelData);

        StopCoroutine(_coroutine);
    }

    private void SetTheScene()
    {
        Time.timeScale = 0;

        _creatingController.CreateScene();
        _waveController.SpawnFirstWave(_levelData);
    }
    
    private bool IsLevelLosed()
    {
        if (_levelData.LoseLevel)
        {
            Time.timeScale = 0;
            return true;
        }
        return false;
    }
}
