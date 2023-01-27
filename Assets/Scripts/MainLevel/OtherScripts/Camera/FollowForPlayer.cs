using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowForPlayer : MonoBehaviour
{
    [SerializeField] private Transform _targetOfFollowing;
    [SerializeField] private float _speedOfFollowing;
    [SerializeField] private float _yPosition;
    
    void FixedUpdate()
    {
        Vector3 position = _targetOfFollowing.position;
        position.y = _yPosition;
        transform.position = Vector3.Lerp(transform.position, position, _speedOfFollowing * Time.deltaTime);
    }
}
