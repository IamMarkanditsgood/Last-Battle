using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipData
{
    public class PlayerData : MonoBehaviour, IGanListOfShip, IAbilitiesOfShip
    {
        public static PlayerData instance;

        [SerializeField] private GameObject _cursor;
        [SerializeField] private List<Transform> _positionAroundPlayer;
        [SerializeField] private List<GameObject> _guns;
        [SerializeField] private List<GameObject> _abilities;
        [SerializeField] private float _playerSpeed;
        [SerializeField] private float _health;
        [SerializeField] private float _shield;

        private Rigidbody _rigidbody;

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

        public GameObject Cursor
        {
            get { return _cursor; }
        }

        public List<GameObject> TakeListOfGuns()
        {
            return _guns;
        }

        public List<GameObject> TakeListOfAbilities()
        {
            return _abilities;
        }
        public float PlayerSpeed { get { return _playerSpeed; } set { _playerSpeed = value; } }
        public float Health { get { return _health; } set { _health = value; } }
        public float Shield { get { return _shield; } set { _shield = value; } }
    }
}
