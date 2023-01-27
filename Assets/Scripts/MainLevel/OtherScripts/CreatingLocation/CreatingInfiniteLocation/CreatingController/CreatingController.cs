using UnityEngine;

public class CreatingController : MonoBehaviour
{
    [SerializeField] private LevelData _levelData;
    // можливо унаслідувати абстракцію від монобехейвора щоб можна було у інспекторі добавити їх у лист
    private AFirstSpawn[] _firstSpawns = {new SpawnOfMeteorites(), new SpawnOfEnemys(), new SpawnOfProjectiles() , new SpawnOfEffects(), new SpawnOfSounds()};
    void Start()
    {
       foreach(var firstSpawn in _firstSpawns)
       {
           firstSpawn.FirstSpawn();
       }
    }
}