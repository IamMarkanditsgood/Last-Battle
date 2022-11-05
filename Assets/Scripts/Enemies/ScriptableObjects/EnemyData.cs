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

    public ERacesOfShips RaceOfShip => _raceOfShip;
    public EEnemiesType TypeOfShip => _typeOfEnemy;
    public float Health => _health;
    public float Shield => _shield;
}
