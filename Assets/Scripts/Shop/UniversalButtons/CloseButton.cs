using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    [SerializeField] private GameObject _UIThatShoodBeClosed;

    public void CloseUI()
    {
        _UIThatShoodBeClosed.SetActive(false);
    }
}
