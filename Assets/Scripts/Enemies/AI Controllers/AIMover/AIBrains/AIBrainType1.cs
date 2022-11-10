using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIBrainType1 : IAITypesOfBrain
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
        return player.transform.position;
    }
    private Vector3 AIFindOutTarget(GameObject player)
    {
        float randomX = Random.Range(player.transform.position.x - 50f, player.transform.position.x + 50);
        float randomZ = Random.Range(player.transform.position.z - 50, player.transform.position.z + 50);
        Vector3 target = new Vector3(randomX, 0f, randomZ);
        //Instantiate(_targetObject, target, Quaternion.identity);
        return target;
    }
}
