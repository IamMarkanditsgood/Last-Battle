using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTheSight : MonoBehaviour
{
    [SerializeField] private Transform _cursor;
    private void FixedUpdate()
    {
        transform.LookAt(_cursor, Vector3.up);
    }
}
