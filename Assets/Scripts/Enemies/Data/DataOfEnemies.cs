using System.Collections.Generic;
using UnityEngine;

public class DataOfEnemies : AHealtheAndShield, IGanListOfShip, IGetListOfEnemy
{
    [SerializeField] private ERacesOfShips _raceOfShip;
    [SerializeField] private ETypeOfAIBrain _typeOfAIbrain;

    [SerializeField] private EnemyData _scriptableObject;

    [SerializeField] private LayerMask _layerMaskOfEnemy;

    [SerializeField] private List<GameObject> _listOfGun;

    [SerializeField] private GameObject _player;

    [SerializeField] private Transform _positionBehindShip;

    [SerializeField] private float _distanceForShooting;
    [SerializeField] private float _healthe;
    [SerializeField] private float _shield;
    [SerializeField] private float _healtheIndex;
    [SerializeField] private float _shieldIndex;
    [SerializeField] private float _distanceForUsingAiAlgor;

    private List<GameObject> _listOfShipsEnemies = new List<GameObject>();

    private void OnEnable()
    {
        SetEnemiesOfThisShip();
        SetHealtheAndShield();
    }

    public override float GetHealth()
    {
        return _healthe;
    }
    public override float GetShield()
    {
        return _shield;
    }

    public override void SetHealth(float value)
    {
        _healthe = value;
    }
    public override void SetShield(float value)
    {
        _shield = value;
    }

    public List<GameObject> GetEnemyOfThisShip()
    {
        return _listOfShipsEnemies;
    }
    public void SetEnemyOfThisShip(List<GameObject> value)
    {
        _listOfShipsEnemies = value;
    }

    public ERacesOfShips RaceOfShip
    {
        get { return _raceOfShip; }
    }
    public ETypeOfAIBrain TypeOfAIBrain
    {
        get { return _typeOfAIbrain; }
    }

    public EnemyData ScriptableObjectOfEnemy
    {
        get { return _scriptableObject; }
        set { _scriptableObject = value; }
    }

    public LayerMask LayerMaskOfEnemy
    {
        get { return _layerMaskOfEnemy; }
    }

    public List<GameObject> TakeListOfGuns()
    {
        return _listOfGun;
    }
    public List<GameObject> GunList
    {
        get { return _listOfGun; }
    }

    public GameObject Player 
    { 
        get { return _player; } 
        set { _player = value; } 
    }

    public Transform PositionBehindShip
    {
        get { return _positionBehindShip; }
    }

    public float DistanceForShooting
    {
        get { return _distanceForShooting; }
        set { _distanceForShooting = value; }
    }
    public float HealtheIndex
    {
        get { return _healtheIndex; }
        set { _healtheIndex = value; }
    }
    public float ShieldIndex
    {
        get { return _shieldIndex; }
        set { _shieldIndex = value; }
    }
    public float DistanceForUsingAiAlgor
    {
        get { return _distanceForUsingAiAlgor; }
    }

    private void SetEnemiesOfThisShip()
    {
        _listOfShipsEnemies.Add(_player);
    }
    private void SetHealtheAndShield()
    {
        _healthe = _scriptableObject.Health * _healtheIndex;
        _shield = _scriptableObject.Shield * _shieldIndex;
    }

}
