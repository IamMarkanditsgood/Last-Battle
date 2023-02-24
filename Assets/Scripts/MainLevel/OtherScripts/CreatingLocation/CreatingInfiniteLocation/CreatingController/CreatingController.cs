public class CreatingController
{
    // можливо унаслідувати абстракцію від монобехейвора щоб можна було у інспекторі добавити їх у лист
    public void CreateScene()
    {
        AFirstSpawn[] _firstSpawns = 
        { 
            new SpawnOfMeteorites(),
            new SpawnOfEnemys(),
            new SpawnOfProjectiles(),
            new SpawnOfEffects(),
            new SpawnOfSounds() 
        };

        foreach (var firstSpawn in _firstSpawns)
        {
            firstSpawn.FirstSpawn();
        }
    }
}