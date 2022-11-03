using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMoverForShip : MonoBehaviour
{
    
    public void MoveToTarget(Vector3 _target, NavMeshAgent agentOfEnemy)
    {
        agentOfEnemy.SetDestination(_target);
    }
}
