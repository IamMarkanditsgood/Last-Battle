using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMoveController : MonoBehaviour
{
    private Vector3 _movementVector
    {
        get
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");

            return new Vector3(horizontal, 0.0f, vertical);
        }
    }
    void FixedUpdate()
    {
        
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            MovePlayer movePlayer = GetComponent<MovePlayer>();
            movePlayer.Movement(_movementVector);
        }
        
    }
}
