using UnityEngine;

public class CloseButtonMenu : MonoBehaviour
{
    [SerializeField] private GameObject _UIThatShoodBeClosed;
    [SerializeField] private DataOfMenu _dataOfMenu;

    private SoundsController _soundController = new SoundsController();

    public void CloseUI()
    {
        _soundController.UseSoundInMenu(_dataOfMenu);
        _UIThatShoodBeClosed.SetActive(false);
    }
}
