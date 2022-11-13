using UnityEngine;

public class CreatingController : MonoBehaviour
{
    // ������� ����������� ���������� �� ������������� ��� ����� ���� � ��������� �������� �� � ����
    private AFirstSpawn[] _firstSpawns = {new SpawnOfMeteorites(), new SpawnOfEnemys(), new SpawnOfProjectiles() };
    void Start()
    {
       foreach(var firstSpawn in _firstSpawns)
       {
           firstSpawn.FirstSpawn();
       }
    }
}