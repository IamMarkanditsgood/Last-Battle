using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipData
{
    public class PlayerData : MonoBehaviour, IGanListOfShip, IAbilitiesOfShip
    {
        public static PlayerData instance;
        [SerializeField] private GameObject _cursor;
        [SerializeField] private List<GameObject> _particleObjects;
        [SerializeField] private List<Transform> _positionAroundPlayer;
        [SerializeField] private List<GameObject> _guns;
        [SerializeField] private List<GameObject> _abilities;
        [SerializeField] private float _playerSpeed;
        [SerializeField] private float _maxSpeed;
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
        public List<GameObject> ParticleList { get { return _particleObjects; } }
        public GameObject GetParticleObject(ETypeOfEffect eTypeOfEffect)
        {
            for(int i = 0; i < _particleObjects.Count; i++)
            {
                if (_particleObjects[i].GetComponent<EffectObjData>().TypeOfEffect == eTypeOfEffect)
                {
                    return _particleObjects[i];
                }

            }
            print("Error: You have not this Effect in data of enemy!");
            return null;
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
        public float MaxSpeed { get { return _maxSpeed; } set { _maxSpeed = value; } }
        public float Health { get { return _health; } set { _health = value; } }
        public float Shield { get { return _shield; } set { _shield = value; } }
    }
}
