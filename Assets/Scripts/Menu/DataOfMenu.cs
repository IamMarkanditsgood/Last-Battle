using UnityEngine;

public class DataOfMenu : MonoBehaviour
{
    [SerializeField] private GameObject _buttonSound;
    [SerializeField] private GameObject _settingsPanel;

    public GameObject ButtonSound
    {
        get { return _buttonSound; }
    }
    public GameObject SettingPanel 
    { 
        get { return _settingsPanel; } 
    }
}
