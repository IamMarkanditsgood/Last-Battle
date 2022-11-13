using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingOfMass
{
    public void CreateMass(GameObject thisMeteorite)
    {
        Rigidbody rb;
        rb = thisMeteorite.GetComponent<Rigidbody>();
        rb.mass = thisMeteorite.transform.localScale.x * 3;
    }
}
