using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float Speed = 0.3f;
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationX;
    }
    public void Movement(Vector3 _movementVector)
    {
        PlayerData playerData = GetComponent<PlayerData>();
        _rb.AddForce(_movementVector * playerData.PlayerSpeed, ForceMode.Impulse);
    }
}
