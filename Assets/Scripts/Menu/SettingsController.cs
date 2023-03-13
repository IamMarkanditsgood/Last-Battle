using UnityEngine;
using UnityEngine.Audio;

public class SettingsController : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;

    public void ChangeMusicVolume(float volume)
    {
        _mixer.audioMixer.SetFloat("Music", Mathf.Lerp(-80, 20, volume));
    }
    public void ChangeSoundsVolume(float volume)
    {
        print(volume);
        print(Mathf.Lerp(-80, 0, volume));
        _mixer.audioMixer.SetFloat("Sounds", Mathf.Lerp(-80, 20, volume));
    }
}
