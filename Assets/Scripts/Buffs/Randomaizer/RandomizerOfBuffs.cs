using UnityEngine;

public class RandomizerOfBuffs
{
    private const int _basicYPositionForGame = 0;
    public void SpawnRandomBuff(PrefabsStorey prefabsStorey, LevelData levelData)
    {
        Randomizer randomizer = new Randomizer();

        float x = randomizer.RandomXForSpawn(levelData.XLevelSize);
        float y = _basicYPositionForGame;
        float z = randomizer.RandomZForSpawn(levelData.ZLevelSize);

        GameObject randomBuff = GetRandomBuff(prefabsStorey);
        GameObject buff = Object.Instantiate(randomBuff, new Vector3(x, y, z), Quaternion.identity);

        buff.transform.SetParent(levelData.BuffConteiner);

    }
    private GameObject GetRandomBuff(PrefabsStorey prefabsStorey)
    {
        int quantityOfBuffs = prefabsStorey.Buffs.Count;
        int indexOfBaffInList = Random.Range(0, quantityOfBuffs);

        return prefabsStorey.Buffs[indexOfBaffInList];
    }
}
