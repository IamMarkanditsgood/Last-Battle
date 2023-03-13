using UnityEngine;
using UnityEngine.AI;
public class AIBrainType3 : IAITypesOfBrain
{
    //Mayby need change this
    public void AITakeTarget(ref Vector3 target, ref bool isOnTarget, ref NavMeshAgent agent, GameObject thisShip, GameObject player, float distanceToPlayer, float distanceForUsingAI)
    {

        if (distanceToPlayer > distanceForUsingAI)
        {
            target = player.transform.position;
            MoveToTarget(target, agent);
        }
        else if (distanceToPlayer < distanceForUsingAI/2)
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
