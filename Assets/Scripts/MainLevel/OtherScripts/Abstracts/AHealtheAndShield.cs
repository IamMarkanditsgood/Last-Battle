using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AHealtheAndShield : MonoBehaviour 
{
    public abstract float GetHealth();
    public abstract float GetShield();
    public abstract void SetHealth(float value);
    public abstract void SetShield(float value);
}
