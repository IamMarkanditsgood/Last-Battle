using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] private LevelData _levelData;
    private void Start()
    {
        Time.timeScale = 0;
    }
    private void Update()
    {
        if (_levelData.LoseLevel)
        {
            Time.timeScale = 0;
        }
    }
}
