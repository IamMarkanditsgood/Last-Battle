using System;

public class NewWave
{
    public void StartNewWave(WaveController waveController, LevelData levelData)
    {
        levelData.IsPeacefulTime = false;
        levelData.ShopArea.SetActive(false);
        levelData.MainUIDatas.MainLevelUI.ShopButton.SetActive(false);

        SpawnEnemies(waveController, levelData);
    }
    private void SpawnEnemies(WaveController waveController, LevelData levelData)
    {
        ERacesOfShips eRacesOfShips = GetRandomRace();
        switch (levelData.WaveOfEnemies)
        {
            case 1:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, eRacesOfShips, 1);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level2, eRacesOfShips, 2);
                break;
            case 2:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level2, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, eRacesOfShips, 1);
                break;
            case 3:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level2, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, eRacesOfShips, 1);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level4, eRacesOfShips, 1);
                break;
            case 4:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level2, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level4, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.BossType1, eRacesOfShips, 1);
                break;
            case 5:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, eRacesOfShips, 3);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level2, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level4, eRacesOfShips, 1);
                waveController.SpawnEnemy(levelData, EEnemiesType.BossType1, eRacesOfShips, 1);
                break;
            case 6:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, eRacesOfShips, 3);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level2, eRacesOfShips, 3);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level4, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.BossType2, eRacesOfShips, 1);
                break;
            case 7:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, eRacesOfShips, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level2, eRacesOfShips, 3);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level4, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.BossType2, eRacesOfShips, 1);
                break;
            case 8:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, eRacesOfShips, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level2, eRacesOfShips, 3);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level4, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.BossType1, eRacesOfShips, 1);
                waveController.SpawnEnemy(levelData, EEnemiesType.BossType2, eRacesOfShips, 1);
                break;
            case 9:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, eRacesOfShips, 5);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level2, eRacesOfShips, 4);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level4, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.BossType1, eRacesOfShips, 1);
                waveController.SpawnEnemy(levelData, EEnemiesType.BossType2, eRacesOfShips, 1);
                break;
            case 10:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, eRacesOfShips, 5);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level2, eRacesOfShips, 5);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, eRacesOfShips, 3);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level4, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.BossType1, eRacesOfShips, 1);
                waveController.SpawnEnemy(levelData, EEnemiesType.BossType2, eRacesOfShips, 1);
                break;
            case 11:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, eRacesOfShips, 5);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level2, eRacesOfShips, 5);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, eRacesOfShips, 3);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level4, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.BossType1, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.BossType2, eRacesOfShips, 1);
                break;
            case 12:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, eRacesOfShips, 5);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level2, eRacesOfShips, 5);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, eRacesOfShips, 3);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level4, eRacesOfShips, 3);
                waveController.SpawnEnemy(levelData, EEnemiesType.BossType1, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.BossType2, eRacesOfShips, 1);
                break;
            case 13:
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, eRacesOfShips, 5);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level2, eRacesOfShips, 5);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, eRacesOfShips, 3);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level4, eRacesOfShips, 3);
                waveController.SpawnEnemy(levelData, EEnemiesType.BossType1, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.BossType2, eRacesOfShips, 2);
                break;
            default:
                
                waveController.SpawnEnemy(levelData, EEnemiesType.Level1, eRacesOfShips, 5);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level2, eRacesOfShips, 5);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level3, eRacesOfShips, 3);
                waveController.SpawnEnemy(levelData, EEnemiesType.Level4, eRacesOfShips, 3);
                waveController.SpawnEnemy(levelData, EEnemiesType.BossType1, eRacesOfShips, 2);
                waveController.SpawnEnemy(levelData, EEnemiesType.BossType2, eRacesOfShips, 2);
                break;
        }
    }
    private ERacesOfShips GetRandomRace()
    {
        Random _R = new Random();
        var v = Enum.GetValues(typeof(ERacesOfShips));
        return (ERacesOfShips)v.GetValue(_R.Next(v.Length));
    }
}
