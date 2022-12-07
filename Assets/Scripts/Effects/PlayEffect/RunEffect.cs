using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunEffect
{
    public void PlayEffect(List<ParticleSystem> particleSystems)
    {
        for(int i =0; i< particleSystems.Count;i++)
        {
            particleSystems[i].Play();
        }
    }
    public void StopEffect(List<ParticleSystem> particleSystems) 
    {
        for (int i = 0; i < particleSystems.Count; i++)
        {
            particleSystems[i].Stop();
        }
    }
}
