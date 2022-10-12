using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New EnemyData", menuName = "Enemy Data", order = 52)]
public class EnemyData : ScriptableObject
{
    [SerializeField] private EEnemiesType _typeOfEnemy;
    [SerializeField] private ERacesOfShips _raceOfShip;
    [SerializeField] private float _health;
    [SerializeField] private float _shield;

    public ERacesOfShips RaceOfShip
    {
        get { return _raceOfShip; }
    }
    public EEnemiesType TypeOfShip
    {
        get { return _typeOfEnemy; }
    }
    public float Health
    {
        get { return _health; }
    }
    public float Shield
    {
        get { return _shield; }
    }
}
