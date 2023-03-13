using ShipData;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{
    private LevelData _levelData;
    private LevelUIData _levelUIData;
    private SoundsController _soundController = new SoundsController();

    private void Start()
    {
        _levelData = LevelData.instance;
        _levelUIData = GetComponent<LevelUIData>();
    }

    public void OpenShop()
    {
        _soundController.UseSound(ETypeOfSound.ButtonSound);
        _levelUIData.MainDataOfCanvas.Shop.SetActive(true);
        _levelUIData.MainDataOfCanvas.IsShopOpen = true;
        _levelUIData.MainDataOfCanvas.SetCurrentPanel();
        _levelUIData.ShopButton.SetActive(false);
        Time.timeScale = 0;
    }
    public void PlayGame()
    {
        _soundController.UseSound(ETypeOfSound.ButtonSound);
        _levelUIData.StartPanel.SetActive(false);
        _levelData.Player.SetActive(true);
        Time.timeScale = 1;
        _levelData.Player.SetActive(true);
    }
    public void RestartGame()
    {
        _soundController.UseSound(ETypeOfSound.ButtonSound);
        Application.LoadLevel(Application.loadedLevel);
    }
    public void MainMenu()
    {
        _soundController.UseSound(ETypeOfSound.ButtonSound);
        SceneManager.LoadScene(0);
    }
    public void ShootFromGun()
    {
        LevelData levelData = LevelData.instance;
        ShootFromGun shootFromGun = new ShootFromGun();

        PlayerData playerData = levelData.Player.GetComponent<PlayerData>();
        shootFromGun.ShootPlayerGuns(playerData);
    }
}
