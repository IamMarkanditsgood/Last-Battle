using UnityEngine;

public class MessagePanelData : MonoBehaviour
{
    [SerializeField] private GameObject _notEnoughMoneyPanel;
    [SerializeField] private GameObject _enhancementLimitReached;

    public GameObject NotEnoughMoneyPanel
    { 
        get { return _notEnoughMoneyPanel; } 
    }
    public GameObject EnhancementLimitReached
    {
        get { return _enhancementLimitReached; }
    }
}
