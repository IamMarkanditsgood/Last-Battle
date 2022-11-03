using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _objectWithAIScripts;
    private Vector3 _target = new Vector3(10000,10000,10000);
    private IAITypesOfBrain _aiTypesOfBtrain;
    private AIMoverForShip _moverForShip;
    private IsOnTargetCheckerForAI _isOnTargetCheckerForAI;
    private AIController _aiController;
    private NavMeshAgent _myAgent;
    private bool _isOnTarget = true;

    public bool IsOnTarget { get { return _isOnTarget; } set { _isOnTarget = value; } }
    public Vector3 Target { get { return _target; } }

    private void Start()
    {
        _aiController = GetComponent<AIController>();
        _aiTypesOfBtrain = GetComponent<IAITypesOfBrain>();
        _moverForShip = _objectWithAIScripts.GetComponent<AIMoverForShip>();
        _isOnTargetCheckerForAI = _objectWithAIScripts.GetComponent<IsOnTargetCheckerForAI>();
        _myAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        _isOnTargetCheckerForAI.CheckIsOnTarget(gameObject, _target, _aiController);
        _target = _aiTypesOfBtrain.AITakeTarget(_player);
        _moverForShip.MoveToTarget(_target, _myAgent);
    }

}
