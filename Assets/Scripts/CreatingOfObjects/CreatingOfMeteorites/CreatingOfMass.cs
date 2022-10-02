using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingOfMass : MonoBehaviour
{
    public void CreateMass()
    {
        Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.mass = gameObject.transform.localScale.x * 3;
    }
}
