using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] private DataOfMenu _dataOfMenu;

    private void Awake()
    {
        _dataOfMenu.ButtonSound.SetActive(true);
        _dataOfMenu.ButtonSound.GetComponent<AudioSource>().Stop();
    }
}
