using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFromFireGun : MonoBehaviour, IStandardShot
{
    public void Shoot()
    {
        print("Fire Gun is shooting");
    }

}
