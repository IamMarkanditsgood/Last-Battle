using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsController
{
    public void UseExplosionSound(ETypeOfSound eTypeOfSound, GameObject explosionPoint)
    {

        ObjectsComposition objectsComposition = ObjectsComposition.Instance;
        GameObject sound = objectsComposition.GetSound(eTypeOfSound);
        sound.transform.position = explosionPoint.transform.position;
        sound.SetActive(true);
        sound.AddComponent<cleaner>();
    }
}
