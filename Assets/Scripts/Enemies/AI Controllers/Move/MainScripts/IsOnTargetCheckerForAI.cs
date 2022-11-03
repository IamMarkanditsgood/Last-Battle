using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOnTargetCheckerForAI : MonoBehaviour
{
    public void CheckIsOnTarget(GameObject enemy, Vector3 target, AIController aIController)
    {
        float distanceToTarget = Vector3.Distance(enemy.transform.position, target);
        
        if (distanceToTarget <= 1)
        {
            aIController.IsOnTarget = true;
        }
        
    }
}
