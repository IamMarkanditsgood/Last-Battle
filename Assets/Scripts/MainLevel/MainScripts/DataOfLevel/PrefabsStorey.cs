using System.Collections.Generic;
using UnityEngine;

public class PrefabsStorey : MonoBehaviour
{
    public static PrefabsStorey instance;

    [SerializeField] private GameObject _projectile;

    [SerializeField] private List<GameObject> _meteorites;
    [SerializeField] private List<GameObject> _emeniesPrefabs;
    [SerializeField] private List<GameObject> _effects;
    [SerializeField] private List<GameObject> _sounds;
    [SerializeField] private List<GameObject> _buffs;
    
    private void Awake()
    {
        instance = this;
    }
    public GameObject Projectile
    {
        get { return _projectile; }
    }
    
    public List<GameObject> Meteorites
    {
        get { return _meteorites; }
    }
    public List<GameObject> Enemies
    {
        get { return _emeniesPrefabs; }
    }
    public List<GameObject> Effects
    {
        get { return _effects; }
    }
    public List<GameObject> Sounds 
    {
        get { return _sounds; } 
    }
    public List<GameObject> Buffs 
    { 
        get { return _buffs; } 
    }

    public GameObject GetEnemyShipByTypeAndRaceFromPrefabe(ERacesOfShips eRacesOfShips, EEnemiesType eEnemiesType)
    {
        for (int i = 0; i < _emeniesPrefabs.Count; i++)
        {
            EEnemiesType typeOfObject = _emeniesPrefabs[i].GetComponent<DataOfEnemies>().ScriptableObjectOfEnemy.TypeOfShip;
            ERacesOfShips racesOfShips = _emeniesPrefabs[i].GetComponent<DataOfEnemies>().ScriptableObjectOfEnemy.RaceOfShip;
            if (racesOfShips == eRacesOfShips && typeOfObject == eEnemiesType)
            {
                return _emeniesPrefabs[i];
            }
        }
        print("Error: No such object exists!!");
        return null;
    }
}
