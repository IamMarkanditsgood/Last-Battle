using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOfMeteorites : AFirstSpawn
{
    private LevelData _levelData;
    public override void FirstSpawn()
    {
        _levelData = LevelData.instance;
        for (int i = 0;i < _levelData.NumberOfMeteorites; i++)
        {
            Randomizer randomizer = new Randomizer();
            float x = randomizer.RandomXForSpawn(_levelData.XLevelSize);
            float z = randomizer.RandomZForSpawn(_levelData.ZLevelSize);
            GameObject obj = randomizer.RandomObject(PrefabsStorey.instance.Meteorites);
            GameObject meteorite = Object.Instantiate(obj, new Vector3(x, 0, z) , Quaternion.identity);
            meteorite.transform.SetParent(LevelData.instance.MeteoriteConteiner);

        }
    }
}
