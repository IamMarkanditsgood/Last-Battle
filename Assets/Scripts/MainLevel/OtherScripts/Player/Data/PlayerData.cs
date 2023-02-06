using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

namespace ShipData
{
    public class PlayerData : AHealtheAndShield, IGanListOfShip, IAbilitiesOfShip, IGetListOfEnemy
    {
        public static PlayerData instance;


        [SerializeField] private GameObject _sight;
        [SerializeField] private List<Transform> _positionAroundPlayer;
        [SerializeField] private List<GameObject> _guns;
        [SerializeField] private List<GameObject> _abilities;
        [SerializeField] private List<GameObject> _engines;
        [SerializeField] private float _playerSpeed;
        [SerializeField] private float _maxSpeed;
        [SerializeField] private float _health;
        [SerializeField] private float _shield;


        private Rigidbody _rigidbody;
        private LevelData _levelData = LevelData.instance;
        [SerializeField]private List<GameObject> _listOfShipsEnemies;
        private void Awake()
        {
            
            instance = this;
            _rigidbody = GetComponent<Rigidbody>();
          
        }
        public Rigidbody Rigidbody
        {
            get { return _rigidbody; }
        }
        public List<Transform> PositionAroundPlayer
        {
            get { return _positionAroundPlayer; }
        }

        public GameObject Sight
        {
            get { return _sight; }
        }
        public List<GameObject> TakeListOfGuns()
        {
            return _guns;
        }

        public List<GameObject> TakeListOfAbilities()
        {
            return _abilities;
        }
        public List<GameObject> Engines
        {
            get { return _engines; }
        }
        public float PlayerSpeed { get { return _playerSpeed; } set { _playerSpeed = value; } }
        public float MaxSpeed { get { return _maxSpeed; } set { _maxSpeed = value; } }
        public override float GetHealth()
        {
            return _health;
        }
        public override void SetHealth(float value)
        {
            _health = value;
        }
        public override float GetShield()
        {
            return _shield;
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
    }
}
