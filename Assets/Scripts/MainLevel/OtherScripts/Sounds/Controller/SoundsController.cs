using UnityEngine;

public class SoundsController
{
    public void UseSound(ETypeOfSound eTypeOfSound, GameObject soundPoint)
    {
        ObjectsComposition objectsComposition = ObjectsComposition.instance;

        GameObject sound = objectsComposition.GetSound(eTypeOfSound);

        sound.transform.position = soundPoint.transform.position;
        sound.AddComponent<cleaner>();
        sound.SetActive(true);
    }
}
