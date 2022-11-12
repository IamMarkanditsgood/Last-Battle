using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIBrainType1 : IAITypesOfBrain
{
    public void AITakeTarget(ref Vector3 target, ref bool isOnTarget, ref NavMeshAgent agent, GameObject thisShip, GameObject player, float distanceToPlayer)
    {
        if (distanceToPlayer > 20)
        {
            isOnTarget = true;
            target = player.transform.position;
            MoveToTarget(target, agent);
        }
        else if (distanceToPlayer < 20 && isOnTarget)
        {

            isOnTarget = false;
            target = AIFindOutTarget(player);

            MoveToTarget(target, agent);
        }
    }
    private Vector3 AIFindOutTarget(GameObject player)
    {
        float randomX = Random.Range(player.transform.position.x - 10, player.transform.position.x + 10);
        float randomZ = Random.Range(player.transform.position.z - 10, player.transform.position.z + 10);
        Vector3 target = new Vector3(randomX, 0f, randomZ);
        return target;
    }
    private void MoveToTarget(Vector3 target, NavMeshAgent agent)
    {
        Debug.Log(target);
        agent.SetDestination(target);
    }
}
