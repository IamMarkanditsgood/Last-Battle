using UnityEngine;

public class DataOfSound : MonoBehaviour
{
    [SerializeField] private ETypeOfSound _typeOfSound;

    [SerializeField] private AudioSource _audioSource;

    public ETypeOfSound TypeOfSound
    {
        get { return _typeOfSound; }
    }

    public AudioSource AudioSource
    { 
        get { return _audioSource; } 
    }
}
