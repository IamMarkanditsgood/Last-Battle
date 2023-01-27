using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunEffect
{
    public void PlayEffect(GameObject effectObj)
    {
        EffectObjData effectObjData = effectObj.GetComponent<EffectObjData>();
        for(int i =0; i< effectObjData.ParticleSystemsList.Count;i++)
        {
            effectObjData.ParticleSystemsList[i].Play();
        }
    }
    public void StopEffect(GameObject effectObj) 
    {
        EffectObjData effectObjData = effectObj.GetComponent<EffectObjData>();
        for (int i = 0; i < effectObjData.ParticleSystemsList.Count; i++)
        {
            effectObjData.ParticleSystemsList[i].Stop();
        }
    }
}
