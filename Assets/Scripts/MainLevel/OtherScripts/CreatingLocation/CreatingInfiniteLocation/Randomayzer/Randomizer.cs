using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer
{
    public float RandomXForSpawn(float XSizeOfMap)
    {
        return Random.Range(-XSizeOfMap, XSizeOfMap);
    }
    public float RandomZForSpawn(float ZSizeOfMap)
    {
        return Random.Range(-ZSizeOfMap, ZSizeOfMap);
    }
    public GameObject RandomObject(List<GameObject> objects)
    {
        return objects[Random.Range(0,objects.Count)];
    }
}
