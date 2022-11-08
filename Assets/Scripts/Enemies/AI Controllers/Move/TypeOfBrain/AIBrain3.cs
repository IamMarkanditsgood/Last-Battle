using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBrain3 : MonoBehaviour, IAITypesOfBrain
{
    [SerializeField] private float _distanceForStop;
    [SerializeField] private float _distanceForRanBack;

    public Vector3 AITakeTarget(GameObject player)
    {
     
        float distanceToPlayer = Vector3.Distance(player.transform.position, gameObject.transform.position);

        if (distanceToPlayer <= _distanceForStop && distanceToPlayer >= _distanceForRanBack)
        {
            return gameObject.transform.position;
        }
        else if (distanceToPlayer <= _distanceForStop && distanceToPlayer <= _distanceForRanBack)
        {
            return gameObject.transform.position;
            //return AIFindOutTarget(player);
        }
        else
        {
            return player.transform.position;
        }
    }

    private Vector3 AIFindOutTarget(GameObject player)
    {

        Vector3 target = transform.forward * -10;
        Vector3 target2 = new Vector3(target.x, 0f, target.z);
        return target2;
    }
}
