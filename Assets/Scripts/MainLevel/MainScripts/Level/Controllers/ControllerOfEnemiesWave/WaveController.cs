using ShipData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController
{
    public void SpawnFirstWave(LevelData _levelData)
    {
        if (_levelData.CanSpawnOfEnemies)
        {
            SpawnEnemy(_levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 1);
        }
    }
    public void CheckTheWave(LevelController _levelController,LevelData _levelData)
    {
        if (!_levelData.IsPeacefulTime && _levelData.CanSpawnOfEnemies)
        {
            bool newWave = CheckDoesBattleContinue(_levelController,_levelData);
            if (newWave)
            {
                _levelData.WaveOfEnemies++;
                _levelData.ListOfEnemiesOnScene.Clear();
                _levelController.NumberOfKilledEnemies = 0;
                _levelData.ShopArea.SetActive(true);
                _levelData.IsPeacefulTime = true;
                _levelController.StartCoroutine(_levelController.TimeBetweenWaves(_levelData.TimeOfPeace));
            }
        }
    }

    private bool CheckDoesBattleContinue(LevelController _levelController,LevelData _levelData)
    {
        List < GameObject > listOfEnemies = _levelData.ListOfEnemiesOnScene;
        for(int i = 0; i < listOfEnemies.Count; i++)
        {
            if(!listOfEnemies[i].activeInHierarchy)
            {
                _levelController.NumberOfKilledEnemies++;
            }
        }
        if(_levelController.NumberOfKilledEnemies == listOfEnemies.Count)
        {
            _levelController.NumberOfKilledEnemies = 0;
            return true;
        }
        _levelController.NumberOfKilledEnemies = 0;
        return false;
    }
    public void SpawnEnemy(LevelData levelData, EEnemiesType enemyType, ERacesOfShips raceOfEnemy,int numberOfShips )
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
    
    
}
