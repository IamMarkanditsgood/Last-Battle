using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowForPlayer
{
    public void MoveToObject(GameObject obj,Transform targetOfFollowing, float yPositionForObj, float speedForFollowing)
    {
        Vector3 position = targetOfFollowing.position;
        position.y = yPositionForObj;
        obj.transform.position = Vector3.Lerp(obj.transform.position, position, speedForFollowing * Time.deltaTime);
    }
}
