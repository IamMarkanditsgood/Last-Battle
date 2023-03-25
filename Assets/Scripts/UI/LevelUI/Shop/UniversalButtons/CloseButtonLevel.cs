using UnityEngine;

public class CloseButtonLevel : MonoBehaviour
{
    [SerializeField] private GameObject _UIThatShoodBeClosed;

    private SoundsController _soundController = new SoundsController();

    public void CloseUI()
    {
        _soundController.UseSound(ETypeOfSound.ButtonSound);
        _UIThatShoodBeClosed.SetActive(false);
    }
}
