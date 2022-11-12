using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIBrainType3 : IAITypesOfBrain
{
    //Mayby need change this
    public void AITakeTarget(ref Vector3 target, ref bool isOnTarget, ref NavMeshAgent agent, GameObject thisShip, GameObject player, float distanceToPlayer)
    {
        if (distanceToPlayer > 20)
        {
            target = player.transform.position;
            MoveToTarget(target, agent);
        }
        else if (distanceToPlayer < 10)
        {

            target = AIFindOutTarget(thisShip);
            
            MoveToTarget(target, agent);
        }
        /*else
        {
            agent.ResetPath();
        }*/
    }

    private Vector3 AIFindOutTarget(GameObject thisShip)
    {
        Vector3 target = thisShip.GetComponent<DataOfEnemies>().PositionBehindShip.position;
        
        return target;
    }
    private void MoveToTarget(Vector3 target, NavMeshAgent agent)
    {

        agent.SetDestination(target);
    }
}
