using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIBrain1 : MonoBehaviour, IAITypesOfBrain
{
   //[SerializeField] private GameObject _targetObject;
    private AIController _controller;
    private NavMeshAgent _agent;
    private Vector3 target;


    private void Start()
    {
        _controller = gameObject.GetComponent<AIController>();
        _agent = GetComponent<NavMeshAgent>();
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
        float randomX = Random.Range(player.transform.position.x - 10f, player.transform.position.x + 10f);
        float randomZ = Random.Range(player.transform.position.z - 10f, player.transform.position.z + 10f);
        Vector3 target = new Vector3(randomX, 0f, randomZ);
        //Instantiate(_targetObject, target, Quaternion.identity);
        return target;
    }

    
}
