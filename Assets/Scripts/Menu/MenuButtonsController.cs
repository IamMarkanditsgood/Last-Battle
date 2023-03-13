using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonsController : MonoBehaviour
{
    [SerializeField] private DataOfMenu _dataOfMenu;

    private SoundsController _soundController = new SoundsController();

    public void Play()
    {
        _soundController.UseSoundInMenu(_dataOfMenu);
        SceneManager.LoadScene(1);
    }
    public void Settings()
    {
        _soundController.UseSoundInMenu(_dataOfMenu);
        _dataOfMenu.SettingPanel.SetActive(true);
    }
    public void Exit()
    {
        _soundController.UseSoundInMenu(_dataOfMenu);
        Application.Quit();
    }
}
