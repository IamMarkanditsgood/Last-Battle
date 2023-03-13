using UnityEngine;

public class CloseShopPanel : MonoBehaviour
{
    [SerializeField] private GameObject _UIThatShoodBeClosed;
    [SerializeField] private MainDatas _MainDatas;

    private SoundsController _soundController = new SoundsController();

    public void CloseShop()
    {
        _soundController.UseSound(ETypeOfSound.ButtonSound);
        Time.timeScale = 1;
        _MainDatas.IsShopOpen = false;
        _UIThatShoodBeClosed.SetActive(false);
    }
}
