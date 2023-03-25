using System.Collections.Generic;
using UnityEngine;

namespace ShipData
{
    public class PlayerData : AHealtheAndShield, IGanListOfShip, IAbilitiesOfShip, IGetListOfEnemy
    {
        public static PlayerData instance;

        [SerializeField] private GameObject _sight;

        [SerializeField] private List<GameObject> _guns;
        [SerializeField] private List<GameObject> _abilities;
        [SerializeField] private List<GameObject> _engines;
        [SerializeField] private List<GameObject> _listOfShipsEnemies;

        [SerializeField] private List<Transform> _positionAroundPlayer;

        [SerializeField] private float _playerSpeed;
        [SerializeField] private float _maxSpeed;
        [SerializeField] private float _startHP;
        [SerializeField] private float _startShield;
        [SerializeField] private float _health;
        [SerializeField] private float _shield;

        [SerializeField] private bool _isAccelerated;

        private Rigidbody _rigidbody;
        
        private void Awake()
        {
            instance = this;
            _rigidbody = GetComponent<Rigidbody>();

            SetHealth(_startHP);
            SetShield(_startShield);
        }

        public GameObject Sight
        {
            get { return _sight; }
        }

        public List<GameObject> Engines
        {
            get { return _engines; }
        }

        public List<Transform> PositionAroundPlayer
        {
            get { return _positionAroundPlayer; }
        }

        public float StartHP { get { return _startHP; } }
        public float StartShield { get { return _startShield; } }
        public float PlayerSpeed { get { return _playerSpeed; } set { _playerSpeed = value; } }
        public float MaxSpeed { get { return _maxSpeed; } set { _maxSpeed = value; } }

        public bool IsAccelerated { get { return _isAccelerated; } set { _isAccelerated = value; } }

        public Rigidbody Rigidbody
        {
            get { return _rigidbody; }
        }

        public List<GameObject> GetEnemyOfThisShip()
        {
            return _listOfShipsEnemies;
        }
        public void SetEnemyOfThisShip(List<GameObject> value)
        {
            _listOfShipsEnemies = value;
        }

        public List<GameObject> TakeListOfGuns()
        {
            return _guns;
        }

        public List<GameObject> TakeListOfAbilities()
        {
            return _abilities;
        }
        
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

        
        
    }
}
