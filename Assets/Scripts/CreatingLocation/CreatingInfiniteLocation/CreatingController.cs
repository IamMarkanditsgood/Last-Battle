using UnityEngine;

public class CreatingController : MonoBehaviour
{
    [SerializeField] private AFirstSpawn[] _firstSpawns;
    void Start()
    {
       foreach(var firstSpawn in _firstSpawns)
       {
           firstSpawn.FirstSpawn();
       }
    }
}