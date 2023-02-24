using System.Collections.Generic;
using UnityEngine;

public class EffectController
{
    public void UseEffect(ETypeOfEffect eTypeOfEffect, Transform effectPoint)
    {
        ObjectsComposition objectsComposition = ObjectsComposition.instance;
        GameObject effect = objectsComposition.GetEffect(eTypeOfEffect);

        SetPosition(effect, effectPoint);
        SetRotation(effect, effectPoint);
        effect.SetActive(true);
        effect.AddComponent<cleaner>();
    }
    public void RunEngineEffect(ETypeOfEffect eTypeOfEffect, List<GameObject> pointForEffect, ref List<GameObject> curentEngineEffect)
    {
        ObjectsComposition objectsComposition = ObjectsComposition.instance;
        for (int i = 0; i < pointForEffect.Count; i++)
        {
            GameObject effect = objectsComposition.GetEffect(eTypeOfEffect);

            SetPosition(effect, pointForEffect[i].transform);
            effect.transform.rotation = pointForEffect[i].transform.rotation;
            effect.transform.SetParent(pointForEffect[i].transform);
            effect.SetActive(true);
            curentEngineEffect.Add(effect);
        }
    }
    public void StopEngineEffect(List<GameObject> engineEffects)
    {
        for (int i = 0; i < engineEffects.Count; i++)
        {
            engineEffects[i].SetActive(false);
        }
    }
    private void SetPosition(GameObject obj, Transform positionPoint)
    {
        obj.transform.position = positionPoint.transform.position;
    }
    private void SetRotation(GameObject obj, Transform mainRotationObj)
    {
        obj.transform.rotation = mainRotationObj.rotation;
    }
}
