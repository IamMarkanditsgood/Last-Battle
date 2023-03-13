using UnityEngine;

public class SpawnOfMeteorites : AFirstSpawn
{
    private const int yPosition = 0;

    private LevelData _levelData;

    public override void FirstSpawn()
    {
        _levelData = LevelData.instance;

        for (int i = 0; i < _levelData.NumberOfMeteorites; i++)
        {     
            Randomizer randomizer = new Randomizer();
            float xPosition = randomizer.RandomXForSpawn(_levelData.XLevelSize);
            float zPosition = randomizer.RandomZForSpawn(_levelData.ZLevelSize);

            GameObject obj = randomizer.RandomObject(PrefabsStorey.instance.Meteorites);
            GameObject meteorite = Object.Instantiate(obj, new Vector3(xPosition, yPosition, zPosition) , Quaternion.identity);
            meteorite.transform.SetParent(LevelData.instance.MeteoriteConteiner);

        }
    }
}
