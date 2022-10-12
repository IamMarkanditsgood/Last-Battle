using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOfEnemys : AFirstSpawn
{
    private const int _numberOfLV1InPool = 10;
    private const int _numberOfLV2InPool = 10;
    private const int _numberOfLV3InPool = 5;
    private const int _numberOfLV4InPool = 5;
    private const int _numberOfBoss1InPool = 3;
    private const int _numberOfBoss2InPool = 3;
    public override void FirstSpawn()
    {
        List<GameObject> enemies = PrefabsStorey.instance.Enemies;
        for (int i = 0; i < enemies.Count; i++)
        {
            FirstAddToPoolAndSpawn(enemies[i]);
        }
    }
    public void FirstAddToPoolAndSpawn(GameObject prefabOfEnemy)
    {  
        EEnemiesType enemiesType = prefabOfEnemy.GetComponent<DataOfEnemies>().ScriptableObjectOfEnemy.TypeOfShip;
        int number = FindOutNumberOfSpawns(enemiesType);
        for(int i = 0; i < number; i++)
        {
            GameObject enemy = SpawnOfEnemy(prefabOfEnemy);
            AddEnemyShipToList(enemy);
        }
        
    }
    public void AddEnemyShipToList(GameObject enemy)
    {
        List<GameObject> listOfEnemy = ObjectsComposition.Instance.FindListOfShipRace(enemy);
        listOfEnemy.Add(enemy);
        
    }
    public GameObject SpawnOfEnemy(GameObject obj)
    {
        GameObject enemy = Instantiate(obj);
        enemy.SetActive(false);
        enemy.transform.SetParent(LevelData.instance.EnemiesConteiner);
        return enemy;
    }
    
    private int FindOutNumberOfSpawns(EEnemiesType eEnemiesType)
    {
       

        switch (eEnemiesType)
        {
            case 0:
                return _numberOfLV1InPool;

            case (EEnemiesType)1:
                return _numberOfLV2InPool;
            case (EEnemiesType)2:
                return _numberOfLV3InPool;
            case (EEnemiesType)3:
                return _numberOfLV4InPool;
            case (EEnemiesType)4:
                return _numberOfBoss1InPool;
            case (EEnemiesType)5:
                return _numberOfBoss2InPool;
            default:
                print("Error: You still have not create case for this type in class SpawnOfEnemys!!!");
                return 0;
        }
    }

}
