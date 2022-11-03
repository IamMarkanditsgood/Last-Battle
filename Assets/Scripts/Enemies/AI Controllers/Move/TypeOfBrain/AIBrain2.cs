using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIBrain2 : MonoBehaviour, IAITypesOfBrain
{
    [SerializeField] private List<Transform> _positionAroundPlayer;
    private AIController _controller;
    private Vector3 target;
    private NavMeshAgent _agent;


    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _controller = gameObject.GetComponent<AIController>();

    }
    public Vector3 AITakeTarget(GameObject player)
    {
        float distanceToPlayer = Vector3.Distance(player.transform.position, gameObject.transform.position);
        if (distanceToPlayer < 10 && _controller.IsOnTarget == true)
        {

            _agent.ResetPath();
            target = AIFindOutTarget(player);
            _controller.IsOnTarget = false;
            return target;

        }
        else if (distanceToPlayer > 10)
        {
            target = player.transform.position;
            _controller.IsOnTarget = true;
            return target;
        }
        return target;
    }
    private Vector3 AIFindOutTarget(GameObject player)
    {
        Vector3 target = _positionAroundPlayer[Random.Range(0, _positionAroundPlayer.Count)].position;
        return target;
    }

    
}
