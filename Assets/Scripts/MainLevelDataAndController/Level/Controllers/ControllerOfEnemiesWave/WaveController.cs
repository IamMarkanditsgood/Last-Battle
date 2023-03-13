using ShipData;
using System.Collections.Generic;
using UnityEngine;

public class WaveController
{
    private const int _standardTimeOfPeace = 10;

    public void SpawnFirstWave(LevelData _levelData)
    {
        if (_levelData.CanSpawnOfEnemies)
        {
            SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 3);
        }
    }
    public void CheckTheWave(LevelController _levelController,LevelData _levelData, ref Coroutine coroutine)
    {
        if (!_levelData.IsPeacefulTime && _levelData.CanSpawnOfEnemies)
        {
            bool newWave = CheckDoesBattleContinue(_levelController,_levelData);
            if (newWave)
            {
                SetTheTimeBetweenWaves(_levelData);
                _levelData.ListOfEnemiesOnScene.Clear();
                _levelData.WaveOfEnemies++;
                _levelData.IsPeacefulTime = true;
                _levelData.ShopArea.SetActive(true);
                coroutine = _levelController.StartCoroutine(_levelController.TimeBetweenWaves(_levelData.TimeOfPeace));
            }
        }
    }
    public void SpawnEnemy(LevelData levelData, EEnemiesType enemyType, ERacesOfShips raceOfEnemy, int numberOfShips)
    {
        for (int i = 0; i < numberOfShips; i++)
        {
            GameObject enemy = ObjectsComposition.instance.GetEnemyShip(raceOfEnemy, enemyType);

            SetPositionOfEnemy(levelData, enemy);
            SetIndexesOfEnemy(levelData, enemy);

            enemy.GetComponent<DataOfEnemies>().Player = levelData.Player;
            enemy.SetActive(true);
            levelData.ListOfEnemiesOnScene.Add(enemy);
        }
    }

    private void SetTheTimeBetweenWaves(LevelData levelData)
    {
        float dist = Vector3.Distance(levelData.Player.transform.position, levelData.ShopArea.transform.position);
        float maxSpeedOfPlayer = levelData.Player.GetComponent<PlayerData>().MaxSpeed;

        levelData.TimeOfPeace = (dist / maxSpeedOfPlayer) + _standardTimeOfPeace;
    }
    private void SetPositionOfEnemy(LevelData levelData, GameObject enemy)
    {
        int endOfPositionList = levelData.PositionForEnemies.Count;
        Transform positionForSpawn = levelData.PositionForEnemies[Random.Range(0, endOfPositionList)];
        enemy.transform.position = positionForSpawn.position;
    }
    private void SetIndexesOfEnemy(LevelData levelData, GameObject enemy)
    {
        if (levelData.WaveOfEnemies != 0 && (levelData.WaveOfEnemies % 5) == 0)
        {
            DataOfEnemies data =  enemy.GetComponent<DataOfEnemies>();

            data.HealtheIndex++;
            data.ShieldIndex++;

            for(int i = 0;i < data.GunList.Count;i++ )
            {
                data.GunList[i].GetComponent<DataOfGun>().DamageIndex++;
                data.GunList[i].GetComponent<DataOfGun>().TimeRechargeIndex++;
                data.GunList[i].GetComponent<DataOfGun>().SetDamageAndRecharge();
            }
        }
    }

    private bool CheckDoesBattleContinue(LevelController _levelController, LevelData _levelData)
    {
        List<GameObject> listOfEnemies = _levelData.ListOfEnemiesOnScene;
        int NumberOfKilledEnemies = 0;
        for (int i = 0; i < listOfEnemies.Count; i++)
        {
            if (!listOfEnemies[i].activeInHierarchy)
            {
                NumberOfKilledEnemies++;
            }
        }

        if (NumberOfKilledEnemies == listOfEnemies.Count)
        {
            return true;
        }

        return false;
    }


}
