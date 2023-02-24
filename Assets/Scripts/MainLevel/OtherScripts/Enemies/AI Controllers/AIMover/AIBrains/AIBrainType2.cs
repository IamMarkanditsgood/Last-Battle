using UnityEngine;
using UnityEngine.AI;
using ShipData;

public class AIBrainType2 : IAITypesOfBrain
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
            target = AIFindOutTarget(player);
            MoveToTarget(target, agent);
        }
    }

    private Vector3 AIFindOutTarget(GameObject player)
    {
        PlayerData dataOfPlayer = player.GetComponent<PlayerData>();
        Vector3 target = dataOfPlayer.PositionAroundPlayer[Random.Range(0, dataOfPlayer.PositionAroundPlayer.Count)].position;

        return target;
    }

    private void MoveToTarget(Vector3 target, NavMeshAgent agent)
    {
        agent.SetDestination(target);
    }
}
