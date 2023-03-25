using Assets.Scripts.Cleaners;
using UnityEngine;

public class SoundsController
{
    public void UseSound(ETypeOfSound eTypeOfSound, GameObject soundPoint)
    {
        ObjectsComposition objectsComposition = ObjectsComposition.instance;

        GameObject sound = objectsComposition.GetSound(eTypeOfSound);

        sound.transform.position = soundPoint.transform.position;
        sound.AddComponent<Cleaner>();
        sound.SetActive(true);
    }
    public void UseSound(ETypeOfSound eTypeOfSound)
    {
        ObjectsComposition objectsComposition = ObjectsComposition.instance;

        GameObject sound = objectsComposition.GetSound(eTypeOfSound);
        sound.SetActive(true);

        AudioSource audioSource = sound.GetComponent<AudioSource>();
        audioSource.Play();
    }
    public void UseSoundInMenu(DataOfMenu dataOfMenu)
    {
        dataOfMenu.ButtonSound.GetComponent<AudioSource>().Play();
    }
}
