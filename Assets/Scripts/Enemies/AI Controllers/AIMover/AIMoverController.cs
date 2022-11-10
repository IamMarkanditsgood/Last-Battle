using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMoverController
{ 

    public void Move(ref bool isOnTarget, ref Vector3 target, GameObject thisShip, GameObject player , DataOfEnemies dataofEnemy, NavMeshAgent navMeshAgent)
    {
        IsOnTarget(ref isOnTarget, thisShip, target);
        Debug.Log(isOnTarget);
        if (isOnTarget)
        {
            IAITypesOfBrain aITypesOfBrain = TakeTypeOfBrain(dataofEnemy);
            float distanceOfPlayer = Vector3.Distance(thisShip.transform.position, player.transform.position);
            aITypesOfBrain.AITakeTarget(ref isOnTarget, ref navMeshAgent, thisShip, player, distanceOfPlayer);
            MoveToTarget(target, navMeshAgent);
        }
    }
    private void IsOnTarget(ref bool isOnTarget, GameObject thisShip, Vector3 target)
    {
        float distance = Vector3.Distance(thisShip.transform.position, target);
        
        if(distance < 1)
        {
            isOnTarget = true;
        }    
        isOnTarget = false;
    }
    private void MoveToTarget(Vector3 target, NavMeshAgent agent)
    {
        
        agent.SetDestination(target);
    }
    private IAITypesOfBrain TakeTypeOfBrain(DataOfEnemies dataOfEnemy)
    {
        ETypeOfAIBrain aITypesOfBrain = dataOfEnemy.TypeOfAIBrain;
        switch(aITypesOfBrain)
        {
            case 0:
                return new AIBrainType1(); 
            case (ETypeOfAIBrain)1 :
                return new AIBrainType2();
            case (ETypeOfAIBrain)2 :
                return new AIBrainType3();
            default :
                Debug.Log("You have not this type in Enam");
                return new AIBrainType1();
        }
    }
}
