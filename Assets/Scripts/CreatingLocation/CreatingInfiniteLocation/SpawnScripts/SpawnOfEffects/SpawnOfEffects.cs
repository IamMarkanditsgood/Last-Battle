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
        CreatorOfObjectForPool creatorOfObjectForPool = new CreatorOfObjectForPool();
        ObjectsComposition objectsComposition = ObjectsComposition.instance;

        GameObject obj = creatorOfObjectForPool.CreateObjectAndPrepearIt(EffectObject, LevelData.instance.EffectsConteiner);
        objectsComposition.PoolEffects.Add(obj);
    }
    public void CreateEffect(ETypeOfEffect eTypeOfEffect)
    {
        ObjectsComposition objectsComposition = ObjectsComposition.instance;
        PrefabsStorey prefabsStorey = PrefabsStorey.instance;
        CreatorOfObjectForPool creatorOfObjectForPool = new CreatorOfObjectForPool();

        for (int i = 0; i < prefabsStorey.Effects.Count; i++)
        {
            ETypeOfEffect type = prefabsStorey.Effects[i].GetComponent<EffectObjData>().TypeOfEffect;

            if (type == eTypeOfEffect)
            {
                GameObject obj = creatorOfObjectForPool.CreateObjectAndPrepearIt(prefabsStorey.Effects[i], LevelData.instance.EffectsConteiner);
                objectsComposition.PoolEffects.Add(obj);
            }
        }
    }
}
