public class CreatingController
{
    // ������� ����������� ���������� �� ������������� ��� ����� ���� � ��������� �������� �� � ����
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