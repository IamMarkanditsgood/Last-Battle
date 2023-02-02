using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShipData;

public class LevelController : MonoBehaviour
{
    [SerializeField] private LevelData _levelData;
    private void Start()
    {
        Time.timeScale = 0;
        _levelData.Player.SetActive(true);
        CreatingController creatingController = new CreatingController();
        creatingController.CreateScene();
        
    }
    private void Update()
    {
        if (_levelData.LoseLevel)
        {
            Time.timeScale = 0;
        }
    }
}
