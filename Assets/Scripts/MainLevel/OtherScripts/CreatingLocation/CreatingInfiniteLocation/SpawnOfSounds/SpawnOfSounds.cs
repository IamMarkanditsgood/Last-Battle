using System.Collections;
using System.Collections.Generic;
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
        GameObject obj = Object.Instantiate(SoundObject);
        obj.SetActive(false);
        obj.transform.SetParent(LevelData.instance.SoundsConteiner);
        ObjectsComposition objectsComposition = ObjectsComposition.Instance;
        objectsComposition.PoolSounds.Add(obj);

    }
    public void CreateSound(ETypeOfSound eTypeOfSound)
    {
        ObjectsComposition objectsComposition = ObjectsComposition.Instance;
        PrefabsStorey prefabsStorey = PrefabsStorey.instance;
        for (int i = 0; i < prefabsStorey.Sounds.Count; i++)
        {
            ETypeOfSound type = prefabsStorey.Sounds[i].GetComponent<DataOfSound>().TypeOfSound;
            if (type == eTypeOfSound)
            {

                GameObject obj = Object.Instantiate(prefabsStorey.Sounds[i]);
                obj.SetActive(false);
                obj.transform.SetParent(LevelData.instance.SoundsConteiner);
                objectsComposition.PoolSounds.Add(obj);
            }
        }
        Debug.Log("You have not this type of sound" + eTypeOfSound);

    }
}
