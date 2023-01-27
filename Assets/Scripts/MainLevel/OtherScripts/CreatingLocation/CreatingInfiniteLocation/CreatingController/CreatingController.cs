using UnityEngine;

public class CreatingController : MonoBehaviour
{
    [SerializeField] private LevelData _levelData;
    // ������� ����������� ���������� �� ������������� ��� ����� ���� � ��������� �������� �� � ����
    private AFirstSpawn[] _firstSpawns = {new SpawnOfMeteorites(), new SpawnOfEnemys(), new SpawnOfProjectiles() , new SpawnOfEffects(), new SpawnOfSounds()};
    void Start()
    {
       foreach(var firstSpawn in _firstSpawns)
       {
           firstSpawn.FirstSpawn();
       }
    }
}