using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData instance;
    [SerializeField] private List<GameObject> _guns;
    [SerializeField] private List<GameObject> _abilities;
    [SerializeField] private float _playerSpeed;
    [SerializeField] private float _health;
    [SerializeField] private float _shield;
    private void Awake()
    {
        instance = this;
    }
    public List<GameObject> ListOfGans { get { return _guns; }}
    public List<GameObject> ListOfAbilities { get { return _abilities; }}
    public float PlayerSpeed{ get { return _playerSpeed; } set { _playerSpeed = value; }}
    public float Health{ get { return _health; } set { _health = value; }}
    public float Shield { get { return _shield; } set { _shield = value; } }
}
