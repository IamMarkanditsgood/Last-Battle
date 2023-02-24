using UnityEngine;
using UnityEngine.AI;

public class AIBrainType1 : IAITypesOfBrain
{
    public void AITakeTarget(ref Vector3 target, ref bool isOnTarget, ref NavMeshAgent agent, GameObject thisShip, GameObject player, float distanceToPlayer, float distanceForUsingAI)
    {
        if (distanceToPlayer > distanceForUsingAI)
        {
            isOnTarget = true;
            target = player.transform.position;
            MoveToTarget(target, agent);
        }
        else if (distanceToPlayer < distanceForUsingAI && isOnTarget)
        {
            isOnTarget = false;
            target = AIFindOutTarget(player, distanceForUsingAI);
            MoveToTarget(target, agent);
        }
    }

    private Vector3 AIFindOutTarget(GameObject player, float distanceForUsingAI)
    {
        float areaForFindPosition = distanceForUsingAI / 2;
        float randomX = Random.Range(player.transform.position.x - areaForFindPosition, player.transform.position.x + areaForFindPosition);
        float randomZ = Random.Range(player.transform.position.z - areaForFindPosition, player.transform.position.z + areaForFindPosition);

        Vector3 target = new Vector3(randomX, 0f, randomZ);

        return target;
    }
    private void MoveToTarget(Vector3 target, NavMeshAgent agent)
    {
        agent.SetDestination(target);
    }
}
