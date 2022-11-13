using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOfMeteorites : AFirstSpawn
{
    private StartSetings _startSetings;
    public override void FirstSpawn()
    {
        _startSetings = StartSetings.instance;
        for (int i = 0;i < _startSetings.NumberOfMeteorites; i++)
        {
            Randomizer randomizer = new Randomizer();
            float x = randomizer.RandomXForSpawn(_startSetings.XLevelSize);
            float z = randomizer.RandomZForSpawn(_startSetings.ZLevelSize);
            GameObject obj = randomizer.RandomObject(PrefabsStorey.instance.Meteorites);
            GameObject meteorite = Object.Instantiate(obj, new Vector3(x, 0, z) , Quaternion.identity);
            meteorite.transform.SetParent(LevelData.instance.MeteoriteConteiner);
        }
    }
}
