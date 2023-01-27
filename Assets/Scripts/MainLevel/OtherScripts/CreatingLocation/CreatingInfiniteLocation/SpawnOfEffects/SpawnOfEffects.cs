using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOfEffects: AFirstSpawn
{
    private const int _numberOfEveryoneEffects = 5;
    public override void FirstSpawn()
    {
        PrefabsStorey prefabsStorey = PrefabsStorey.instance;
        for (int i = 0; i < prefabsStorey.Effects.Count; i++)
        {
            for(int j = 0; j < _numberOfEveryoneEffects; j++)
            {
                CreateEffect(prefabsStorey.Effects[i]);
            }
        }
    }
    public void CreateEffect(GameObject EffectObject)
    {
        GameObject obj = Object.Instantiate(EffectObject);
        obj.SetActive(false);
        obj.transform.SetParent(LevelData.instance.EffectsConteiner);
        ObjectsComposition objectsComposition = ObjectsComposition.Instance;
        objectsComposition.PoolExplosionEffects.Add(obj);

    }
    public void CreateEffect(ETypeOfEffect eTypeOfEffect)
    {
        ObjectsComposition objectsComposition = ObjectsComposition.Instance;
        PrefabsStorey prefabsStorey = PrefabsStorey.instance;
        for (int i = 0; i < prefabsStorey.Effects.Count; i++)
        {
            ETypeOfEffect type = prefabsStorey.Effects[i].GetComponent<EffectObjData>().TypeOfEffect;
            if (type == eTypeOfEffect)
            {

                GameObject obj = Object.Instantiate(prefabsStorey.Effects[i]);
                obj.SetActive(false);
                obj.transform.SetParent(LevelData.instance.EffectsConteiner);
                objectsComposition.PoolExplosionEffects.Add(obj);
            }
        }
        Debug.Log("You have not this type of effects" + eTypeOfEffect);

    }
}
