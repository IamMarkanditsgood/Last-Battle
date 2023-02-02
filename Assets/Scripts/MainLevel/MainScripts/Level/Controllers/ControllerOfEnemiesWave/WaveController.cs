using ShipData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    [SerializeField] private LevelData _levelData;
    private int numberOfKilledEnemies = 0;
    private Coroutine _coroutine;
    private bool _isBattleTime = true;
    private void Start()
    {
        if (_levelData.CanSpawnOfEnemies)
        {
            SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 1);
        }
    }
    private void Update()
    {
        if (_isBattleTime && _levelData.CanSpawnOfEnemies)
        {
            bool newWave = CheckDoesBattleContinue(_levelData);
            if (newWave)
            {
                _levelData.WaveOfEnemies++;
                _levelData.ListOfEnemiesOnScene.Clear();
                numberOfKilledEnemies = 0;
                _levelData.ShopArea.SetActive(true);
                _isBattleTime = false;
                StartCoroutine(TimeBetweenWaves(_levelData.TimeOfPeace));


            }
        }

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
        _levelData.ShopArea.SetActive(false);
        _isBattleTime = true;
        _levelData.MainDatas.MainLevelUI.ShopButton.SetActive(false);
        StartNewWave(_levelData);
        StopCoroutine(_coroutine);
    }
    private bool CheckDoesBattleContinue(LevelData levelData)
    {
        List < GameObject > listOfEnemies = levelData.ListOfEnemiesOnScene;
        for(int i = 0; i < listOfEnemies.Count; i++)
        {
            if(!listOfEnemies[i].activeInHierarchy)
            {
                numberOfKilledEnemies++;
            }
        }
        if(numberOfKilledEnemies == listOfEnemies.Count)
        {
            numberOfKilledEnemies = 0;
            return true;
        }
        numberOfKilledEnemies = 0;
        return false;
    }
    private void SpawnEnemy(LevelData levelData, EEnemiesType enemyType, ERacesOfShips raceOfEnemy,int numberOfShips )
    {
        for(int i = 0; i < numberOfShips; i++)
        {
            GameObject enemy = ObjectsComposition.Instance.GetEnemyShip(raceOfEnemy, enemyType);
            int endOfPositionList = levelData.PositionForEnemies.Count;
            Transform positionForSpawn = levelData.PositionForEnemies[Random.Range(0, endOfPositionList)];
            enemy.transform.position = positionForSpawn.position;
            enemy.GetComponent<DataOfEnemies>().Player = levelData.Player;
            SetIndexesOfEnemy(levelData, enemy);
            enemy.SetActive(true);
            levelData.ListOfEnemiesOnScene.Add(enemy);
        }
    }
    private void SetIndexesOfEnemy(LevelData levelData, GameObject enemy)
    {
        if ((levelData.WaveOfEnemies % 5) == 0)
        {
            DataOfEnemies data =  enemy.GetComponent<DataOfEnemies>();
            data.HealtheIndex++;
            data.ShieldIndex++;
            for(int i = 0;i < data.GunList.Count;i++ )
            {
                data.GunList[i].GetComponent<DataOfGun>().DamageIndex++;
                data.GunList[i].GetComponent<DataOfGun>().TimeRechargeIndex++;
            }
        }
    }
    private void StartNewWave(LevelData levelData)
    {

        switch (levelData.WaveOfEnemies)
        {
            case 1:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 2);
                SpawnEnemy(_levelData, EEnemiesType.Level2, ERacesOfShips.Imperium, 2);
                break;
            case 2:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 2);
                SpawnEnemy(_levelData, EEnemiesType.Level2, ERacesOfShips.Imperium, 2);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 1);
                break;
            case 3:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 4:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 2);
                SpawnEnemy(_levelData, EEnemiesType.Level2, ERacesOfShips.Imperium, 2);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                SpawnEnemy(_levelData, EEnemiesType.Level4, ERacesOfShips.Imperium, 1);
                break;
            case 5:////MustContinue
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 6:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 7:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 8:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 9:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 10:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 11:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 12:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 13:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 14:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 15:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 16:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 17:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 18:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 19:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 20:
                SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                SpawnEnemy(_levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
        }

    }
}
