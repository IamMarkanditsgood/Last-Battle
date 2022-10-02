using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingOfMeteorite : MonoBehaviour
{
    void Start()
    {
        RandomRotation randomRotation = new RandomRotation();
        RandomSizeOfMeteorite randomSize = GetComponent<RandomSizeOfMeteorite>();// чому перший скрипт працює у такій формі а цей не працює
        CreatingOfMass creatingOfMass = GetComponent<CreatingOfMass>();
        randomRotation.RandomRotations(gameObject, 360f);
        randomSize.RandomSizes(gameObject);
        creatingOfMass.CreateMass();
    }
}
