using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIBrainType3 : IAITypesOfBrain
{
    public Vector3 AITakeTarget(ref bool isOnTarget, ref NavMeshAgent agent, GameObject thisShip, GameObject player, float distanceToPlayer)
    {
        if (distanceToPlayer <= 10 && distanceToPlayer >= 20)
        {
            return thisShip.transform.position;
        }
        else if (distanceToPlayer <= 10 && distanceToPlayer <= 20)
        {
            return thisShip.transform.position;
            //return AIFindOutTarget(thisShip);
        }
        else
        {
            return player.transform.position;
        }
    }

    private Vector3 AIFindOutTarget(GameObject thisShip)
    {

        Vector3 target = thisShip.transform.forward * -10;
        Vector3 target2 = new Vector3(target.x, 0f, target.z);
        return target2;
    }
}
