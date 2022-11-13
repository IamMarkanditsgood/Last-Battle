using UnityEngine;

public class CreatingController : MonoBehaviour
{
    // можливо унаслідувати абстракцію від монобехейвора щоб можна було у інспекторі добавити їх у лист
    private AFirstSpawn[] _firstSpawns = {new SpawnOfMeteorites(), new SpawnOfEnemys(), new SpawnOfProjectiles() };
    void Start()
    {
       foreach(var firstSpawn in _firstSpawns)
       {
           firstSpawn.FirstSpawn();
       }
    }
}