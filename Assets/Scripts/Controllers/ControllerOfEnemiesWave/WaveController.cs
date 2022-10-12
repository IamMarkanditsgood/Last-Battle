using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    private void Update()
    {
        LevelData LevelDataInstance = LevelData.instance;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (LevelDataInstance.WaveOfEnemies)
            {
                case 0:
                    int numberOfPosition = Random.Range(0, LevelDataInstance.PositionForEnemies.Count);
                    GameObject obj = ObjectsComposition.Instance.GetEnemyShip((ERacesOfShips)0, (EEnemiesType)2);
                    obj.transform.position = LevelDataInstance.PositionForEnemies[numberOfPosition].position;
                    obj.SetActive(true);
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;

            }
        }
    }
}
