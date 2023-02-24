using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataWeaponsPanel : MonoBehaviour
{
    [SerializeField] private List<DataOfGunPanel> _gunPanels;
    [SerializeField] private List<GameObject> _pagesOfGunsPanels;

    [SerializeField] private TextMeshProUGUI _pagesText;

    [SerializeField] private GameObject _currentPanel;

    private void Start()
    {
        for (int i = 0; i < _pagesOfGunsPanels.Count; i++)
        {
            if (_pagesOfGunsPanels[i].activeInHierarchy)
            {
                _currentPanel = _pagesOfGunsPanels[i];
                _pagesText.SetText(i + 1 + "/" + _pagesOfGunsPanels.Count);
            }
        }
    }
    public List<DataOfGunPanel> GunPanels
    {
        get { return _gunPanels; }
    }
    public List<GameObject> PagesOfGunsPanels
    {
        get { return _pagesOfGunsPanels; }
    }

    public TextMeshProUGUI PagesText
    {
        get { return _pagesText; }
    }

    public GameObject CurrentPanel
    {
        get { return _currentPanel; }
        set { _currentPanel = value; }
    }
}
