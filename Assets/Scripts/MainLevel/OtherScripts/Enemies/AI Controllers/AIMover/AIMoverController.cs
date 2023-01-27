using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMoverController
{ 

    public void Move(ref bool isOnTarget, ref Vector3 target, GameObject thisShip, GameObject player , DataOfEnemies dataofEnemy, NavMeshAgent navMeshAgent)
    {
        IAITypesOfBrain aITypesOfBrain = TakeTypeOfBrain(dataofEnemy);
        IsOnTarget(ref isOnTarget, thisShip, target);
        float distanceOfPlayer = Vector3.Distance(thisShip.transform.position, player.transform.position);
        float distanceForUsingAi = dataofEnemy.DistanceForUsingAiAlgor;
        aITypesOfBrain.AITakeTarget(ref target ,ref isOnTarget, ref navMeshAgent, thisShip, player, distanceOfPlayer, distanceForUsingAi);
    }
    private void IsOnTarget(ref bool isOnTarget,GameObject thisShip,Vector3 target)
    {
        float distance = Vector3.Distance(thisShip.transform.position, target);
        if(distance < 1)
        {
            isOnTarget = true;
        }
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
