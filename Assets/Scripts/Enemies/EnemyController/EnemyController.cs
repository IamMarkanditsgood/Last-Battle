using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    private DataOfEnemies _dataOfEnemies;
    private LookAtPlayer _lookAtPlayer = new LookAtPlayer();
    private bool _isOnTarget = true;
    private Vector3 _target;
    private NavMeshAgent _agent;
    void Start()
    {
        _target = gameObject.transform.position;
        _agent = GetComponent<NavMeshAgent>();
        _dataOfEnemies = GetComponent<DataOfEnemies>();
    }
    void Update()
    {
        HealtheAndShieldController healtheAndShieldController = new HealtheAndShieldController();
        healtheAndShieldController.CheckHealtheAndShield(_dataOfEnemies.Healthe, _dataOfEnemies.Shield, gameObject, false);
        AIMoverController Movecontroller = new AIMoverController();
        Movecontroller.Move(ref _isOnTarget, ref _target, gameObject, _dataOfEnemies.Player, _dataOfEnemies, _agent);
    }
    private void FixedUpdate()
    {
        ViewIsOnShootDistance viewIsOnShootDistance = new ViewIsOnShootDistance();
        viewIsOnShootDistance.IsOnShootDistance(_dataOfEnemies.LayerMaskOfEnemy, gameObject, _dataOfEnemies.DistanceForShooting);
        _lookAtPlayer.RotateOnPlayer(gameObject, _dataOfEnemies.Player);
        
    }
}
