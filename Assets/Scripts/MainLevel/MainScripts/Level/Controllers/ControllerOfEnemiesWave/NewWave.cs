using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWave
{
    public void StartNewWave(WaveController waveController, LevelData levelData)
    {
        levelData.ShopArea.SetActive(false);
        levelData.IsPeacefulTime = false;
        levelData.MainUIDatas.MainLevelUI.ShopButton.SetActive(false);
        switch (levelData.WaveOfEnemies)
        {
            case 1:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level2, ERacesOfShips.Imperium, 2);
                break;
            case 2:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level2, ERacesOfShips.Imperium, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 1);
                break;
            case 3:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 4:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level2, ERacesOfShips.Imperium, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level4, ERacesOfShips.Imperium, 1);
                break;
            case 5:////MustContinue
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 6:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 7:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 8:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 9:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 10:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 11:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 12:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 13:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 14:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 15:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 16:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 17:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 18:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 19:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
            case 20:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, ERacesOfShips.Imperium, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, ERacesOfShips.Imperium, 2);
                break;
        }
    }
}
