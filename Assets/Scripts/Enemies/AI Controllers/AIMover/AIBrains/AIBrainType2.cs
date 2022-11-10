using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using ShipData;
public class AIBrainType2 : IAITypesOfBrain
{
    public Vector3 AITakeTarget(ref bool isOnTarget, ref NavMeshAgent agent, GameObject thisShip, GameObject player, float distanceToPlayer)
    {
        Vector3 target;
        if (distanceToPlayer < 10 && isOnTarget == true)
        {

            agent.ResetPath();
            target = AIFindOutTarget(player);
            isOnTarget = false;
            return target;

        }
        else if (distanceToPlayer > 10)
        {
            target = player.transform.position;
            isOnTarget = true;
            return target;
        }
        return player.transform.position; ;
    }
    private Vector3 AIFindOutTarget(GameObject player)
    {
        PlayerData dataOfPlayer = player.GetComponent<PlayerData>();
        Vector3 target = dataOfPlayer.PositionAroundPlayer[Random.Range(0, dataOfPlayer.PositionAroundPlayer.Count)].position;
        return target;
    }
}
