using UnityEngine;

public class SpawnOfSounds : AFirstSpawn
{
    private const int _numberOfEveryoneSounds = 5;

    public override void FirstSpawn()
    {
        PrefabsStorey prefabsStorey = PrefabsStorey.instance;
        for (int i = 0; i < prefabsStorey.Sounds.Count; i++)
        {
            for (int j = 0; j < _numberOfEveryoneSounds; j++)
            {
                CreateSound(prefabsStorey.Sounds[i]);
            }
        }
    }

    public void CreateSound(GameObject SoundObject)
    {
        ObjectsComposition objectsComposition = ObjectsComposition.instance;
        CreatorOfObjectForPool creatorOfObjectForPool = new CreatorOfObjectForPool();

        GameObject obj = creatorOfObjectForPool.CreateObjectAndPrepearIt(SoundObject, LevelData.instance.SoundsConteiner);
        objectsComposition.PoolSounds.Add(obj);
    }

    public void CreateSound(ETypeOfSound eTypeOfSound)
    {
        ObjectsComposition objectsComposition = ObjectsComposition.instance;
        PrefabsStorey prefabsStorey = PrefabsStorey.instance;
        CreatorOfObjectForPool creatorOfObjectForPool = new CreatorOfObjectForPool();

        for (int i = 0; i < prefabsStorey.Sounds.Count; i++)
        {
            ETypeOfSound type = prefabsStorey.Sounds[i].GetComponent<DataOfSound>().TypeOfSound;
            if (type == eTypeOfSound)
            {
                GameObject obj = creatorOfObjectForPool.CreateObjectAndPrepearIt(prefabsStorey.Sounds[i], LevelData.instance.SoundsConteiner);
                objectsComposition.PoolSounds.Add(obj);
            }
        }
    }
}
