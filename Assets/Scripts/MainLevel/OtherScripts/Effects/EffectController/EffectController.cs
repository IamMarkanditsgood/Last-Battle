using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectController
{
    public void UseExplosionEffect(ETypeOfEffect eTypeOfEffect, Transform explosionPoint)
    {

        ObjectsComposition objectsComposition = ObjectsComposition.Instance;
        GameObject effect = objectsComposition.GetEffect(eTypeOfEffect);

        effect.transform.position = explosionPoint.transform.position;
        effect.transform.rotation = explosionPoint.rotation;
        effect.SetActive(true);
        effect.AddComponent<cleaner>();
    }
    public void RunEngineEffect(ETypeOfEffect eTypeOfEffect, List<GameObject> pointForEffect, ref List<GameObject> curentEngineEffect)
    {

        ObjectsComposition objectsComposition = ObjectsComposition.Instance;
        
        
        for (int i = 0; i < pointForEffect.Count; i++)
        {
            GameObject effect = objectsComposition.GetEffect(eTypeOfEffect);
            effect.transform.position = pointForEffect[i].transform.position;
            effect.SetActive(true);
            
            effect.transform.SetParent(pointForEffect[i].transform);
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
    
}
